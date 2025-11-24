using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNFreeRenderLayerList(BNRenderLayer** renderLayers)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFreeRenderLayerList"
        )]
		internal static extern void BNFreeRenderLayerList(
			
			// BNRenderLayer** renderLayers
		    IntPtr renderLayers  
		);
	}
}