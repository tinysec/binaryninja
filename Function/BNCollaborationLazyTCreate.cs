using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNCollaborationLazyT* BNCollaborationLazyTCreate(void** ctor, void* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNCollaborationLazyTCreate"
        )]
		internal static extern IntPtr BNCollaborationLazyTCreate(
			
			// void** ctor
		    IntPtr ctor  , 
			
			// void* context
		    IntPtr context  
		);
	}
}