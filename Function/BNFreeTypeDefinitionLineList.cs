using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeTypeDefinitionLineList(BNTypeDefinitionLine* list, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeTypeDefinitionLineList"
        )]
		internal static extern void BNFreeTypeDefinitionLineList(
			
			// BNTypeDefinitionLine* list
		    IntPtr list  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}