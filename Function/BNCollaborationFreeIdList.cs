using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNCollaborationFreeIdList(uint64_t* ids, uint64_t size)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationFreeIdList"
        )]
		internal static extern void BNCollaborationFreeIdList(
			
			// uint64_t* ids
		    IntPtr ids  , 
			
			// uint64_t size
		    ulong size  
		);
	}
}