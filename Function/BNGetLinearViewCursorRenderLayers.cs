using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRenderLayer** BNGetLinearViewCursorRenderLayers(BNLinearViewCursor* cursor, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewCursorRenderLayers"
        )]
		internal static extern IntPtr BNGetLinearViewCursorRenderLayers(
			
			// BNLinearViewCursor* cursor
		    IntPtr cursor  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}