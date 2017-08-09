// This file is part of the scopefocusDriverNew project
// 
// File: Driver.cs  Created: 2017-08-09@23:04
// Last modified: 2017-08-10@00:43

using System.Runtime.InteropServices;

namespace ASCOM.scopefocus6
    {
    [Guid("d6fd70ac-856c-4ec2-bad1-d234be5e6f13")]
    [ProgId(InstanceId)]
    [ComVisible(true)]
    public partial class Focuser
        {
        private const string InstanceDescription = "scopefocus6 Focuser (second instance)";
        private const string InstanceId = "ASCOM.scopefocus6B.Focuser";

        // Default public constructor passes the instance-specific IDs into the private constructor in the shared code.
        public Focuser() : this(InstanceId, InstanceDescription) { }
        }
    }