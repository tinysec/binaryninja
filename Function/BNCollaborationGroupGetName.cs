using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationGroupGetName(BNCollaborationGroup* group)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGroupGetName"
        )]
		internal static extern IntPtr BNCollaborationGroupGetName(
			
			// BNCollaborationGroup* _group
		    IntPtr _group  
		);
	}
}