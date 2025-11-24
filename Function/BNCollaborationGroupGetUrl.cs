using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNCollaborationGroupGetUrl(BNCollaborationGroup* group)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationGroupGetUrl"
        )]
		internal static extern IntPtr BNCollaborationGroupGetUrl(
			
			// BNCollaborationGroup* _group
		    IntPtr _group  
		);
	}
}