using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRemoveLinearViewCursorRenderLayer(BNLinearViewCursor* cursor, BNRenderLayer* layer)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveLinearViewCursorRenderLayer"
        )]
		internal static extern void BNRemoveLinearViewCursorRenderLayer(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// BNRenderLayer* layer
		    IntPtr layer  
		);
	}
}