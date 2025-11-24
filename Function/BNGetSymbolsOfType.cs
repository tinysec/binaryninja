using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol** BNGetSymbolsOfType(BNBinaryView* view, BNSymbolType type, uint64_t* count, BNNameSpace* nameSpace)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetSymbolsOfType"
        )]
		internal static extern IntPtr BNGetSymbolsOfType(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbolType type
		    SymbolType type  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// BNNameSpace* _nameSpace
		    IntPtr _nameSpace  
		);
	}
}