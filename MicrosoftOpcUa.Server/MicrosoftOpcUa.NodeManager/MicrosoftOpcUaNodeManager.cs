using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;
using Opc.Ua;
using Opc.Ua.Server;
using MicrosoftOpcUa;
using MicrosoftOpcUa.Core;
using MicrosoftOpcUa.DataProvider.Windows;
using System.IO;

using MicrosoftOpcUa.Publisher;

namespace MicrosoftOpcUa
{
    public class MicrosoftOpcUaNodeManager : CustomNodeManager2
    {
        private readonly MicrosoftOpcUaServerConfiguration m_configuration;
        private MachineState machineState;
        private uint m_nodeIdCounter;
        private Timer m_refreshTimer;

        public MicrosoftOpcUaNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = Namespaces.MicrosoftOpcUa;
            namespaceUrls[1] = Namespaces.MicrosoftOpcUa + "/Instance";
            SetNamespaces(namespaceUrls);
            m_configuration = configuration.ParseExtension<MicrosoftOpcUaServerConfiguration>();
            if (m_configuration == null)
            {
                m_configuration = new MicrosoftOpcUaServerConfiguration();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (m_refreshTimer != null)
                {
                    Utils.SilentDispose(m_refreshTimer);
                    m_refreshTimer = null;
                }
            }
        }

        public override NodeId New(ISystemContext context, NodeState node)
        {
            return new NodeId(++m_nodeIdCounter, NamespaceIndexes[1]);
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "MicrosoftOpcUa.PredefinedNodes.uanodes",
                typeof(MicrosoftOpcUaNodeManager).GetTypeInfo().Assembly,
                true);
            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(
                   Objects.Machine,
                    NamespaceIndexes[0]), typeof(BaseObjectState));
                machineState = new MachineState(null);
                machineState.Create(SystemContext, passiveNode);
                AddPredefinedNode(SystemContext, machineState);
                machineState.RegistPublishers(SystemContext);
                m_refreshTimer = new Timer(DoRefresh, null, 10, 10);
            }
        }


        public override void DeleteAddressSpace()
        {
            lock (Lock)
            {
                base.DeleteAddressSpace();
            }
        }

        protected override NodeHandle GetManagerHandle(
            ServerSystemContext context,
            NodeId nodeId,
            IDictionary<NodeId, NodeState> cache)
        {
            lock (Lock)
            {
                if (!IsNodeIdInNamespace(nodeId))
                {
                    return null;
                }
                if (PredefinedNodes != null)
                {

                    if (PredefinedNodes.TryGetValue(nodeId, out NodeState node))
                    {
                        NodeHandle handle = new NodeHandle
                        {
                            NodeId = nodeId,
                            Validated = true,
                            Node = node
                        };
                        return handle;
                    }
                }
                return null;
            }
        }
        protected override NodeState ValidateNode(
            ServerSystemContext context,
            NodeHandle handle,
            IDictionary<NodeId, NodeState> cache)
        {
            if (handle == null)
            {
                return null;
            }
            if (handle.Validated)
            {
                return handle.Node;
            }
            return null;
        }

        private void DoRefresh(object state)
        {
            try
            {
                PublisherManager.Tick();
            }
            catch (Exception e)
            {
                Utils.Trace(e, "Unexpected error during refresh.");
            }
        }

    }
}
