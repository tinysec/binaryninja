using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNComponentRemoveComponent(BNComponent* component)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentRemoveComponent"
        )]
		internal static extern bool BNComponentRemoveComponent(
			
			// BNComponent* component
		    IntPtr component  
		);
	}
}