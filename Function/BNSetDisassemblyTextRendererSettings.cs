using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetDisassemblyTextRendererSettings(BNDisassemblyTextRenderer* renderer, BNDisassemblySettings* settings)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetDisassemblyTextRendererSettings"
        )]
		internal static extern void BNSetDisassemblyTextRendererSettings(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  , 
			
			// BNDisassemblySettings* settings
		    IntPtr settings  
			
		);
	}
}