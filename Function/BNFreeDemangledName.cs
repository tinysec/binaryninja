using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeDemangledName(const char*** name, uint64_t nameElements)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNFreeDemangledName"
        )]
		internal static extern void BNFreeDemangledName(
			
			// const char*** name
		    IntPtr name  , 
			
			// uint64_t nameElements
		    ulong nameElements  
			
		);
	}
}