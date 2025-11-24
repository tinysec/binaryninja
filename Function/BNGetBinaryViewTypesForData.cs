using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBinaryViewType** BNGetBinaryViewTypesForData(BNBinaryView* data, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBinaryViewTypesForData"
        )]
		internal static extern IntPtr BNGetBinaryViewTypesForData(
			
			// BNBinaryView* data
		    IntPtr data  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}