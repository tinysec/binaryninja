using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyTextRendererArchitecture(BNDisassemblyTextRenderer* renderer, BNArchitecture* arch)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyTextRendererArchitecture"
        )]
		internal static extern void BNSetDisassemblyTextRendererArchitecture(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// BNArchitecture* arch
		    IntPtr arch  
			
		);
	}
}