using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureMember* BNGetStructureMemberAtOffset(BNStructure* s, int64_t offset, uint64_t* idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetStructureMemberAtOffset"
        )]
		internal static extern IntPtr BNGetStructureMemberAtOffset(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t* idx
		    out ulong idx  
		);
	}
}