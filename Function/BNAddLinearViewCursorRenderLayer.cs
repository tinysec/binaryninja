using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddLinearViewCursorRenderLayer(BNLinearViewCursor* cursor, BNRenderLayer* layer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddLinearViewCursorRenderLayer"
        )]
		internal static extern void BNAddLinearViewCursorRenderLayer(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// BNRenderLayer* layer
		    IntPtr layer  
		);
	}
}