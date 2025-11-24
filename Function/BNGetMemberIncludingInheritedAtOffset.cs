using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNInheritedStructureMember* BNGetMemberIncludingInheritedAtOffset(BNStructure* s, BNBinaryView* view, int64_t offset)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetMemberIncludingInheritedAtOffset"
        )]
		internal static extern IntPtr BNGetMemberIncludingInheritedAtOffset(
			
			// BNStructure* s
		    IntPtr s  , 
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// int64_t offset
		    long offset  
			
		);
	}
}