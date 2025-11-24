using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataRenderer* BNNewDataRendererReference(BNDataRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewDataRendererReference"
        )]
		internal static extern IntPtr BNNewDataRendererReference(
			
			// BNDataRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}