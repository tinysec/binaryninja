using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// const char* BNGetRenderLayerName(BNRenderLayer* renderLayer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetRenderLayerName"
        )]
		internal static extern IntPtr BNGetRenderLayerName(
			
			// BNRenderLayer* renderLayer
		    IntPtr renderLayer  
		);
	}
}