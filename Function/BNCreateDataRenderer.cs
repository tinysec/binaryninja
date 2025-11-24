using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNDataRenderer* BNCreateDataRenderer(BNCustomDataRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCreateDataRenderer"
        )]
		internal static extern IntPtr BNCreateDataRenderer(
			
			// BNCustomDataRenderer* renderer
		    IntPtr renderer  
		);
	}
}