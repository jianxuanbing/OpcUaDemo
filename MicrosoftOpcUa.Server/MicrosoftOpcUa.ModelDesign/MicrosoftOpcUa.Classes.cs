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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace MicrosoftOpcUa
{
    #region MachineInfoState Class
    #if (!OPCUA_EXCLUDE_MachineInfoState)
    /// <summary>
    /// Stores an instance of the MachineInfo ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineInfoState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineInfoState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MicrosoftOpcUa.ObjectTypes.MachineInfo, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvTWljcm9zb2Z0T3BjVWH/////BGCAAAEAAAAB" +
           "ABMAAABNYWNoaW5lSW5mb0luc3RhbmNlAQGdOgEBnTr/////AgAAABVgiQoCAAAAAQAJAAAAQ1BVX1Vz" +
           "YWdlAQGaOgAvAD+aOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAJAAAATUVNX1VzYWdlAQGbOgAv" +
           "AD+bOgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the CPU_Usage Variable.
        /// </summary>
        public BaseDataVariableState<string> CPU_Usage
        {
            get
            {
                return m_cPU_Usage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_cPU_Usage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_cPU_Usage = value;
            }
        }

        /// <summary>
        /// A description for the MEM_Usage Variable.
        /// </summary>
        public BaseDataVariableState<string> MEM_Usage
        {
            get
            {
                return m_mEM_Usage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mEM_Usage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mEM_Usage = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_cPU_Usage != null)
            {
                children.Add(m_cPU_Usage);
            }

            if (m_mEM_Usage != null)
            {
                children.Add(m_mEM_Usage);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MicrosoftOpcUa.BrowseNames.CPU_Usage:
                {
                    if (createOrReplace)
                    {
                        if (CPU_Usage == null)
                        {
                            if (replacement == null)
                            {
                                CPU_Usage = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                CPU_Usage = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = CPU_Usage;
                    break;
                }

                case MicrosoftOpcUa.BrowseNames.MEM_Usage:
                {
                    if (createOrReplace)
                    {
                        if (MEM_Usage == null)
                        {
                            if (replacement == null)
                            {
                                MEM_Usage = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                MEM_Usage = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = MEM_Usage;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_cPU_Usage;
        private BaseDataVariableState<string> m_mEM_Usage;
        #endregion
    }
    #endif
    #endregion

    #region MachineLogState Class
    #if (!OPCUA_EXCLUDE_MachineLogState)
    /// <summary>
    /// Stores an instance of the MachineLog ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineLogState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineLogState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MicrosoftOpcUa.ObjectTypes.MachineLog, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvTWljcm9zb2Z0T3BjVWH/////BGCAAAEAAAAB" +
           "ABIAAABNYWNoaW5lTG9nSW5zdGFuY2UBAZ46AQGeOv////8DAAAAFWCJCgIAAAABAAQAAABMaW5lAQGf" +
           "OgAvAD+fOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAFAAAASW5kZXgBAaA6AC8AP6A6AAAADP//" +
           "//8CAv////8AAAAAFWCJCgIAAAABAAUAAABDb3VudAEBqzoALwA/qzoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the Line Variable.
        /// </summary>
        public BaseDataVariableState<string> Line
        {
            get
            {
                return m_line;
            }

            set
            {
                if (!Object.ReferenceEquals(m_line, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_line = value;
            }
        }

        /// <summary>
        /// A description for the Index Variable.
        /// </summary>
        public BaseDataVariableState<string> Index
        {
            get
            {
                return m_index;
            }

            set
            {
                if (!Object.ReferenceEquals(m_index, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_index = value;
            }
        }

        /// <summary>
        /// A description for the Count Variable.
        /// </summary>
        public BaseDataVariableState<string> Count
        {
            get
            {
                return m_count;
            }

            set
            {
                if (!Object.ReferenceEquals(m_count, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_count = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_line != null)
            {
                children.Add(m_line);
            }

            if (m_index != null)
            {
                children.Add(m_index);
            }

            if (m_count != null)
            {
                children.Add(m_count);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MicrosoftOpcUa.BrowseNames.Line:
                {
                    if (createOrReplace)
                    {
                        if (Line == null)
                        {
                            if (replacement == null)
                            {
                                Line = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Line = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Line;
                    break;
                }

                case MicrosoftOpcUa.BrowseNames.Index:
                {
                    if (createOrReplace)
                    {
                        if (Index == null)
                        {
                            if (replacement == null)
                            {
                                Index = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Index = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Index;
                    break;
                }

                case MicrosoftOpcUa.BrowseNames.Count:
                {
                    if (createOrReplace)
                    {
                        if (Count == null)
                        {
                            if (replacement == null)
                            {
                                Count = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                Count = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = Count;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_line;
        private BaseDataVariableState<string> m_index;
        private BaseDataVariableState<string> m_count;
        #endregion
    }
    #endif
    #endregion

    #region MachineFolderState Class
    #if (!OPCUA_EXCLUDE_MachineFolderState)
    /// <summary>
    /// Stores an instance of the MachineFolder ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineFolderState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineFolderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MicrosoftOpcUa.ObjectTypes.MachineFolder, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvTWljcm9zb2Z0T3BjVWH/////BGCAAAEAAAAB" +
           "ABUAAABNYWNoaW5lRm9sZGVySW5zdGFuY2UBAZw6AQGcOv////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <summary>
    /// Stores an instance of the MachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(MicrosoftOpcUa.ObjectTypes.MachineType, MicrosoftOpcUa.Namespaces.MicrosoftOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACcAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvTWljcm9zb2Z0T3BjVWH/////hGCAAAEAAAAB" +
           "ABMAAABNYWNoaW5lVHlwZUluc3RhbmNlAQGhOgEBoToB/////wIAAACEYMAKAQAAAAsAAABQZXJmb3Jt" +
           "YW5jZQEAEgAAAE1hY2hpbmVQZXJmb3JtYW5jZQEBojoALwEBnTqiOgAAAf////8CAAAAFWCJCgIAAAAB" +
           "AAkAAABDUFVfVXNhZ2UBAaM6AC8AP6M6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAkAAABNRU1f" +
           "VXNhZ2UBAaQ6AC8AP6Q6AAAADP////8BAf////8AAAAAhGDACgEAAAADAAAATG9nAQAKAAAATWFjaGlu" +
           "ZUxvZwEBqDoALwEBnjqoOgAAAf////8DAAAAFWCJCgIAAAABAAQAAABMaW5lAQGpOgAvAD+pOgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAFAAAASW5kZXgBAao6AC8AP6o6AAAADP////8CAv////8AAAAA" +
           "FWCJCgIAAAABAAUAAABDb3VudAEBrDoALwA/rDoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the MachinePerformance Object.
        /// </summary>
        public MachineInfoState Performance
        {
            get
            {
                return m_performance;
            }

            set
            {
                if (!Object.ReferenceEquals(m_performance, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_performance = value;
            }
        }

        /// <summary>
        /// A description for the MachineLog Object.
        /// </summary>
        public MachineLogState Log
        {
            get
            {
                return m_log;
            }

            set
            {
                if (!Object.ReferenceEquals(m_log, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_log = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_performance != null)
            {
                children.Add(m_performance);
            }

            if (m_log != null)
            {
                children.Add(m_log);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case MicrosoftOpcUa.BrowseNames.Performance:
                {
                    if (createOrReplace)
                    {
                        if (Performance == null)
                        {
                            if (replacement == null)
                            {
                                Performance = new MachineInfoState(this);
                            }
                            else
                            {
                                Performance = (MachineInfoState)replacement;
                            }
                        }
                    }

                    instance = Performance;
                    break;
                }

                case MicrosoftOpcUa.BrowseNames.Log:
                {
                    if (createOrReplace)
                    {
                        if (Log == null)
                        {
                            if (replacement == null)
                            {
                                Log = new MachineLogState(this);
                            }
                            else
                            {
                                Log = (MachineLogState)replacement;
                            }
                        }
                    }

                    instance = Log;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private MachineInfoState m_performance;
        private MachineLogState m_log;
        #endregion
    }
    #endif
    #endregion
}