using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t* BNGetCallees(BNBinaryView* view, BNReferenceSource* callSite, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCallees"
        )]
		internal static extern IntPtr BNGetCallees(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNReferenceSource* callSite
		    in BNReferenceSource callSite  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}