using MicrosoftOpcUa.Logstash.Service;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MicrosoftOpcUa
{
    class Program
    {
        public static bool isWindows = true;
        static void Main(string[] args)
        {
            Console.Title = "HuaWei OPC_UA Server";
            isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
 
            IoTServer server = new IoTServer(true, 5000);
            server.Run();
            int exitCode = (int)IoTServer.ExitCode;
            Console.Write($"退出代码: {exitCode.ToString()}"); Console.ReadLine();
        }

        public class IoTServer
        {
            MicrosoftOpcUaServer server;
            Task status;
            DateTime lastEventTime;
            IList<Session> lastSessions = null;
            int serverRunTime = Timeout.Infinite;
            static bool autoAccept = false;
            static ExitCode exitCode;

            public IoTServer(bool _autoAccept, int _stopTimeout)
            {
                autoAccept = _autoAccept;
                serverRunTime = _stopTimeout == 0 ? Timeout.Infinite : _stopTimeout * 1000;
            }

            public void Run()
            {

                try
                {
                    exitCode = ExitCode.ErrorServerNotStarted;
                    MicrosoftOpcUaServer().Wait();
                    Console.WriteLine("服务已启动. 按 Ctrl-C 退出...");
                    exitCode = ExitCode.ErrorServerRunning;
                }
                catch (Exception ex)
                {
                    Utils.Trace("服务启动结果异常:" + ex.Message);
                    Console.WriteLine("异常: {0}", ex.Message);
                    exitCode = ExitCode.ErrorServerException;
                    return;
                }

                ManualResetEvent quitEvent = new ManualResetEvent(false);
                try
                {
                    Console.CancelKeyPress += (sender, eArgs) =>
                    {
                        quitEvent.Set();
                        eArgs.Cancel = true;
                    };
                }
                catch
                {
                }
                quitEvent.WaitOne(serverRunTime);
                if (server != null)
                {
                    Console.WriteLine("服务已停止. 等待退出...");
                    using (MicrosoftOpcUaServer _server = server)
                    {
                        server = null;
                        status.Wait();
                        _server.Stop();
                    }
                }
                exitCode = ExitCode.Ok;
            }

            public static ExitCode ExitCode { get => exitCode; }

            private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
            {
                if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
                {
                    e.Accept = autoAccept;
                    if (autoAccept)
                    {
                        Console.WriteLine("认证通过: {0}", e.Certificate.Subject);
                    }
                    else
                    {
                        Console.WriteLine("认证失败: {0}", e.Certificate.Subject);
                    }
                }
            }
            private async Task MicrosoftOpcUaServer()
            {
                ApplicationInstance application = new ApplicationInstance
                {
                    ApplicationName = "MicrosoftPerformanceOpcUaServer",
                    ApplicationType = ApplicationType.Server,
                    ConfigSectionName = "MicrosoftOpcUa"
                };
                ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);
                bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
                if (!haveAppCertificate)
                {
                    throw new Exception("应用程序实例认证失败!");
                }
                if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
                }
                server = new MicrosoftOpcUaServer();
                await application.Start(server);
                status = Task.Run(new Action(StatusThread));
                server.CurrentInstance.SessionManager.SessionActivated += EventStatus;
                server.CurrentInstance.SessionManager.SessionClosing += EventStatus;
                server.CurrentInstance.SessionManager.SessionCreated += EventStatus;
            }

            private void EventStatus(Session session, SessionEventReason reason)
            {
                lastEventTime = DateTime.UtcNow;
                PrintSessionStatus(session, reason.ToString());
            }

            void PrintSessionStatus(Session session, string reason, bool lastContact = false)
            {
                lock (session.DiagnosticsLock)
                {
                    string item = String.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);
                    if (lastContact)
                    {
                        item += String.Format("Last Event:{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
                    }
                    else
                    {
                        if (session.Identity != null)
                        {
                            item += String.Format(":{0,20}", session.Identity.DisplayName);
                        }
                        item += String.Format(":{0}", session.Id);
                    }
                    Console.WriteLine(item);
                }
            }

            private async void StatusThread()
            {
                while (server != null)
                {
                    if (DateTime.UtcNow - lastEventTime > TimeSpan.FromMilliseconds(6000))
                    {
                        IList<Session> sessions = server.CurrentInstance.SessionManager.GetSessions();
                        if (lastSessions != null && lastSessions.Count != sessions.Count)
                        {
                            for (int ii = 0; ii < sessions.Count; ii++)
                            {
                                Session session = sessions[ii];
                                PrintSessionStatus(session, "-Status-", true);
                            }
                        }
                        lastEventTime = DateTime.UtcNow;
                        lastSessions = sessions;
                    }
                    await Task.Delay(1000);
                }
            }
        }



        public enum ExitCode : int
        {
            Ok = 0,
            ErrorServerNotStarted = 0x80,
            ErrorServerRunning = 0x81,
            ErrorServerException = 0x82,
            ErrorInvalidCommandLine = 0x100
        };
    }
}
