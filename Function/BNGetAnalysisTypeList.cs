using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNQualifiedNameAndType* BNGetAnalysisTypeList(BNBinaryView* view, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetAnalysisTypeList"
        )]
		internal static extern IntPtr BNGetAnalysisTypeList(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}