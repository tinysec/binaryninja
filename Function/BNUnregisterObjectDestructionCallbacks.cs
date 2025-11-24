using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNUnregisterObjectDestructionCallbacks(BNObjectDestructionCallbacks* callbacks)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNUnregisterObjectDestructionCallbacks"
        )]
		internal static extern void BNUnregisterObjectDestructionCallbacks(
			
			// BNObjectDestructionCallbacks* callbacks
		    IntPtr callbacks  
			
		);
	}
}