using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNProcessSymbolQueue(BNSymbolQueue* queue)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNProcessSymbolQueue"
        )]
		internal static extern void BNProcessSymbolQueue(
			
			// BNSymbolQueue* queue
		    IntPtr queue  
			
		);
	}
}