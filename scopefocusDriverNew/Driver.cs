// This file is part of the scopefocusDriverNew project
// 
// File: Driver.cs  Created: 2017-08-09@20:28
// Last modified: 2017-08-10@00:53

using System.Runtime.InteropServices;

namespace ASCOM.scopefocus6
    {
    [Guid("622b8413-a845-4039-ab7b-404b4d7ff6b1")]
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