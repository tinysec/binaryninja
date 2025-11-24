using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblySettings* BNGetDisassemblyTextRendererSettings(BNDisassemblyTextRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDisassemblyTextRendererSettings"
        )]
		internal static extern IntPtr BNGetDisassemblyTextRendererSettings(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}