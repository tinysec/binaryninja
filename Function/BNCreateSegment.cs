using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSegment* BNCreateSegment(uint64_t start, uint64_t length, uint64_t dataOffset, uint64_t dataLength, uint32_t flags, bool autoDefined)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateSegment"
        )]
		internal static extern IntPtr BNCreateSegment(
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t length
		    ulong length  , 
			
			// uint64_t dataOffset
		    ulong dataOffset  , 
			
			// uint64_t dataLength
		    ulong dataLength  , 
			
			// uint32_t flags
		    uint flags  , 
			
			// bool autoDefined
		    bool autoDefined  
		);
	}
}