using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddUserSegment(BNBinaryView* view, uint64_t start, uint64_t length, uint64_t dataOffset, uint64_t dataLength, uint32_t flags)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddUserSegment"
        )]
		internal static extern void BNAddUserSegment(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t length
		    ulong length  , 
			
			// uint64_t dataOffset
		    ulong dataOffset  , 
			
			// uint64_t dataLength
		    ulong dataLength  , 
			
			// uint32_t flags
		    uint flags  
		);
	}
}