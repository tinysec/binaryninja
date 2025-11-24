using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol** BNGetSymbols(BNBinaryView* view, uint64_t* count, BNNameSpace* nameSpace)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetSymbols"
        )]
		internal static extern IntPtr BNGetSymbols(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// BNNameSpace* _nameSpace
			IntPtr ns  
		);
	}
}