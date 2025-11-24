using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRenderLayerDefaultEnableState BNGetRenderLayerDefaultEnableState(BNRenderLayer* renderLayer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetRenderLayerDefaultEnableState"
        )]
		internal static extern RenderLayerDefaultEnableState BNGetRenderLayerDefaultEnableState(
			
			// BNRenderLayer* renderLayer
		    IntPtr renderLayer  
			
		);
	}
}