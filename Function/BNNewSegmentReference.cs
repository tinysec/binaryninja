using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSegment* BNNewSegmentReference(BNSegment* seg)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewSegmentReference"
        )]
		internal static extern IntPtr BNNewSegmentReference(
			
			// BNSegment* seg
		    IntPtr seg  
			
		);
	}
}