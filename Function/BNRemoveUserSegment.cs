using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveUserSegment(BNBinaryView* view, uint64_t start, uint64_t length)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRemoveUserSegment"
        )]
		internal static extern void BNRemoveUserSegment(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t length
		    ulong length  
			
		);
	}
}