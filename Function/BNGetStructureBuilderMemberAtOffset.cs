using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNStructureMember* BNGetStructureBuilderMemberAtOffset(BNStructureBuilder* s, int64_t offset, uint64_t* idx)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetStructureBuilderMemberAtOffset"
        )]
		internal static extern IntPtr BNGetStructureBuilderMemberAtOffset(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// int64_t offset
		    long offset  , 
			
			// uint64_t* idx
		    IntPtr idx  
			
		);
	}
}