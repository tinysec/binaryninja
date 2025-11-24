using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNResetDisassemblyTextRendererDeduplicatedComments(BNDisassemblyTextRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNResetDisassemblyTextRendererDeduplicatedComments"
        )]
		internal static extern void BNResetDisassemblyTextRendererDeduplicatedComments(
			
			// BNDisassemblyTextRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}