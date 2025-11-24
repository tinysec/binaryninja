using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationGroup* BNNewCollaborationGroupReference(BNCollaborationGroup* group)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewCollaborationGroupReference"
        )]
		internal static extern IntPtr BNNewCollaborationGroupReference(
			
			// BNCollaborationGroup* _group
		    IntPtr _group  
			
		);
	}
}