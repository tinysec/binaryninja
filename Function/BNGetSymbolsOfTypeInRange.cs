using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNSymbol** BNGetSymbolsOfTypeInRange(BNBinaryView* view, BNSymbolType type, uint64_t start, uint64_t len, uint64_t* count, BNNameSpace* nameSpace)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetSymbolsOfTypeInRange"
        )]
		internal static extern IntPtr BNGetSymbolsOfTypeInRange(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbolType type
		    SymbolType type  , 
			
			// uint64_t start
		    ulong start  , 
			
			// uint64_t len
		    ulong len  , 
			
			// uint64_t* count
		    out ulong count  , 
			
			// BNNameSpace* _nameSpace
		    IntPtr _nameSpace  
		);
	}
}