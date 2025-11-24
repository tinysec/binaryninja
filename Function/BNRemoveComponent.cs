using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNRemoveComponent(BNBinaryView* view, BNComponent* component)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNRemoveComponent"
        )]
		internal static extern bool BNRemoveComponent(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNComponent* component
		    IntPtr component  
		);
	}
}