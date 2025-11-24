using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTagReference* BNGetDataTagsInRange(BNBinaryView* view, uint64_t start, uint64_t end, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDataTagsInRange"
        )]
		internal static extern IntPtr BNGetDataTagsInRange(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t end
		    ulong end  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}