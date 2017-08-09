// This file is part of the scopefocusDriverNew project
// 
// File: Driver.cs  Created: 2017-08-09@20:28
// Last modified: 2017-08-09@23:22

using System.Runtime.InteropServices;

namespace ASCOM.scopefocus6
    {
    [Guid("837ce112-da1f-49c2-b933-628e8ea7ec15")]
    [ProgId(InstanceId)]
    [ComVisible(true)]
    public partial class Focuser
        {
        private const string InstanceDescription = "scopefocus6 Focuser";
        private const string InstanceId = "ASCOM.scopefocus6A.Focuser";

        // Default public constructor passes the instance-specific IDs into the private constructor in the shared code.
        public Focuser() : this(InstanceId, InstanceDescription) { }
        }
    }