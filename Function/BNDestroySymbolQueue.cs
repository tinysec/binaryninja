using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDestroySymbolQueue(BNSymbolQueue* queue)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNDestroySymbolQueue"
        )]
		internal static extern void BNDestroySymbolQueue(
			
			// BNSymbolQueue* queue
		    IntPtr queue  
			
		);
	}
}