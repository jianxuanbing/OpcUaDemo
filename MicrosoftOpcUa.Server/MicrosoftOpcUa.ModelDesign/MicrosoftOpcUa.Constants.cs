/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace MicrosoftOpcUa
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the MachineType_Performance Object.
        /// </summary>
        public const uint MachineType_Performance = 15010;

        /// <summary>
        /// The identifier for the MachineType_Log Object.
        /// </summary>
        public const uint MachineType_Log = 15016;

        /// <summary>
        /// The identifier for the Machine Object.
        /// </summary>
        public const uint Machine = 15001;

        /// <summary>
        /// The identifier for the Machine_Performance Object.
        /// </summary>
        public const uint Machine_Performance = 15013;

        /// <summary>
        /// The identifier for the Machine_Log Object.
        /// </summary>
        public const uint Machine_Log = 15021;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the MachineInfo ObjectType.
        /// </summary>
        public const uint MachineInfo = 15005;

        /// <summary>
        /// The identifier for the MachineLog ObjectType.
        /// </summary>
        public const uint MachineLog = 15006;

        /// <summary>
        /// The identifier for the MachineFolder ObjectType.
        /// </summary>
        public const uint MachineFolder = 15004;

        /// <summary>
        /// The identifier for the MachineType ObjectType.
        /// </summary>
        public const uint MachineType = 15009;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the MachineInfo_CPU_Usage Variable.
        /// </summary>
        public const uint MachineInfo_CPU_Usage = 15002;

        /// <summary>
        /// The identifier for the MachineInfo_MEM_Usage Variable.
        /// </summary>
        public const uint MachineInfo_MEM_Usage = 15003;

        /// <summary>
        /// The identifier for the MachineLog_Line Variable.
        /// </summary>
        public const uint MachineLog_Line = 15007;

        /// <summary>
        /// The identifier for the MachineLog_Index Variable.
        /// </summary>
        public const uint MachineLog_Index = 15008;

        /// <summary>
        /// The identifier for the MachineLog_Count Variable.
        /// </summary>
        public const uint MachineLog_Count = 15019;

        /// <summary>
        /// The identifier for the MachineType_Performance_CPU_Usage Variable.
        /// </summary>
        public const uint MachineType_Performance_CPU_Usage = 15011;

        /// <summary>
        /// The identifier for the MachineType_Performance_MEM_Usage Variable.
        /// </summary>
        public const uint MachineType_Performance_MEM_Usage = 15012;

        /// <summary>
        /// The identifier for the MachineType_Log_Line Variable.
        /// </summary>
        public const uint MachineType_Log_Line = 15017;

        /// <summary>
        /// The identifier for the MachineType_Log_Index Variable.
        /// </summary>
        public const uint MachineType_Log_Index = 15018;

        /// <summary>
        /// The identifier for the MachineType_Log_Count Variable.
        /// </summary>
        public const uint MachineType_Log_Count = 15020;

        /// <summary>
        /// The identifier for the Machine_Performance_CPU_Usage Variable.
        /// </summary>
        public const uint Machine_Performance_CPU_Usage = 15014;

        /// <summary>
        /// The identifier for the Machine_Performance_MEM_Usage Variable.
        /// </summary>
        public const uint Machine_Performance_MEM_Usage = 15015;

        /// <summary>
        /// The identifier for the Machine_Log_Line Variable.
        /// </summary>
        public const uint Machine_Log_Line = 15022;

        /// <summary>
        /// The identifier for the Machine_Log_Index Variable.
        /// </summary>
        public const uint Machine_Log_Index = 15023;

        /// <summary>
        /// The identifier for the Machine_Log_Count Variable.
        /// </summary>
        public const uint Machine_Log_Count = 15024;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the MachineType_Performance Object.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Performance = new ExpandedNodeId(MicrosoftOpcUa.Objects.MachineType_Performance, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Log Object.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Log = new ExpandedNodeId(MicrosoftOpcUa.Objects.MachineType_Log, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine Object.
        /// </summary>
        public static readonly ExpandedNodeId Machine = new ExpandedNodeId(MicrosoftOpcUa.Objects.Machine, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Performance Object.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Performance = new ExpandedNodeId(MicrosoftOpcUa.Objects.Machine_Performance, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Log Object.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Log = new ExpandedNodeId(MicrosoftOpcUa.Objects.Machine_Log, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the MachineInfo ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineInfo = new ExpandedNodeId(MicrosoftOpcUa.ObjectTypes.MachineInfo, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineLog ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineLog = new ExpandedNodeId(MicrosoftOpcUa.ObjectTypes.MachineLog, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineFolder ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineFolder = new ExpandedNodeId(MicrosoftOpcUa.ObjectTypes.MachineFolder, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MachineType = new ExpandedNodeId(MicrosoftOpcUa.ObjectTypes.MachineType, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the MachineInfo_CPU_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineInfo_CPU_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineInfo_CPU_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineInfo_MEM_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineInfo_MEM_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineInfo_MEM_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineLog_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineLog_Line = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineLog_Line, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineLog_Index Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineLog_Index = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineLog_Index, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineLog_Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineLog_Count = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineLog_Count, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Performance_CPU_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Performance_CPU_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineType_Performance_CPU_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Performance_MEM_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Performance_MEM_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineType_Performance_MEM_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Log_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Log_Line = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineType_Log_Line, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Log_Index Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Log_Index = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineType_Log_Index, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the MachineType_Log_Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId MachineType_Log_Count = new ExpandedNodeId(MicrosoftOpcUa.Variables.MachineType_Log_Count, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Performance_CPU_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Performance_CPU_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.Machine_Performance_CPU_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Performance_MEM_Usage Variable.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Performance_MEM_Usage = new ExpandedNodeId(MicrosoftOpcUa.Variables.Machine_Performance_MEM_Usage, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Log_Line Variable.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Log_Line = new ExpandedNodeId(MicrosoftOpcUa.Variables.Machine_Log_Line, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Log_Index Variable.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Log_Index = new ExpandedNodeId(MicrosoftOpcUa.Variables.Machine_Log_Index, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);

        /// <summary>
        /// The identifier for the Machine_Log_Count Variable.
        /// </summary>
        public static readonly ExpandedNodeId Machine_Log_Count = new ExpandedNodeId(MicrosoftOpcUa.Variables.Machine_Log_Count, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Count component.
        /// </summary>
        public const string Count = "Count";

        /// <summary>
        /// The BrowseName for the CPU_Usage component.
        /// </summary>
        public const string CPU_Usage = "CPU_Usage";

        /// <summary>
        /// The BrowseName for the Index component.
        /// </summary>
        public const string Index = "Index";

        /// <summary>
        /// The BrowseName for the Line component.
        /// </summary>
        public const string Line = "Line";

        /// <summary>
        /// The BrowseName for the Log component.
        /// </summary>
        public const string Log = "MachineLog";

        /// <summary>
        /// The BrowseName for the Machine component.
        /// </summary>
        public const string Machine = "Machine";

        /// <summary>
        /// The BrowseName for the MachineFolder component.
        /// </summary>
        public const string MachineFolder = "MachineFolder";

        /// <summary>
        /// The BrowseName for the MachineInfo component.
        /// </summary>
        public const string MachineInfo = "MachineInfo";

        /// <summary>
        /// The BrowseName for the MachineLog component.
        /// </summary>
        public const string MachineLog = "MachineLog";

        /// <summary>
        /// The BrowseName for the MachineType component.
        /// </summary>
        public const string MachineType = "MachineType";

        /// <summary>
        /// The BrowseName for the MEM_Usage component.
        /// </summary>
        public const string MEM_Usage = "MEM_Usage";

        /// <summary>
        /// The BrowseName for the Performance component.
        /// </summary>
        public const string Performance = "MachinePerformance";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the MicrosoftOpcUa namespace (.NET code namespace is 'MicrosoftOpcUa').
        /// </summary>
        public const string MicrosoftOpcUa = "http://opcfoundation.org/MicrosoftOpcUa";
    }
    #endregion
}