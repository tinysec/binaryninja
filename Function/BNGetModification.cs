using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNModificationStatus BNGetModification(BNBinaryView* view, uint64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetModification"
        )]
		internal static extern ModificationStatus BNGetModification(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t offset
		    ulong offset  
		);
	}
}