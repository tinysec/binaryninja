using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAppendSymbolQueue(BNSymbolQueue* queue, void** resolve, void* resolveContext, void** add, void* addContext)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAppendSymbolQueue"
        )]
		internal static extern void BNAppendSymbolQueue(
			
			// BNSymbolQueue* queue
		    IntPtr queue  , 
			
			// void** resolve
		    IntPtr resolve  , 
			
			// void* resolveContext
		    IntPtr resolveContext  , 
			
			// void** _add
		    IntPtr _add  , 
			
			// void* addContext
		    IntPtr addContext  
		);
	}
}