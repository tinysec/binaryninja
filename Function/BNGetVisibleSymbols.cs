using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol** BNGetVisibleSymbols(BNBinaryView* view, uint64_t* count, BNNameSpace* nameSpace)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetVisibleSymbols"
        )]
		internal static extern IntPtr BNGetVisibleSymbols(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    IntPtr count  , 
			
			// BNNameSpace* _nameSpace
		    IntPtr _nameSpace  
			
		);
	}
}