using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterTypeSpecificDataRenderer(BNDataRendererContainer* container, BNDataRenderer* renderer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterTypeSpecificDataRenderer"
        )]
		internal static extern void BNRegisterTypeSpecificDataRenderer(
			
			// BNDataRendererContainer* container
		    IntPtr container  , 
			
			// BNDataRenderer* renderer
		    IntPtr renderer  
			
		);
	}
}