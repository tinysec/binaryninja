using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRelocationHandler* BNNewRelocationHandlerReference(BNRelocationHandler* handler)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewRelocationHandlerReference"
        )]
		internal static extern IntPtr BNNewRelocationHandlerReference(
			
			// BNRelocationHandler* handler
		    IntPtr handler  
			
		);
	}
}