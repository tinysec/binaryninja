using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDisassemblyTextRenderer* BNNewDisassemblyTextRendererReference(BNDisassemblyTextRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewDisassemblyTextRendererReference"
        )]
		internal static extern IntPtr BNNewDisassemblyTextRendererReference(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}