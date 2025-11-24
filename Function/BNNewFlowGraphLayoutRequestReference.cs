using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNFlowGraphLayoutRequest* BNNewFlowGraphLayoutRequestReference(BNFlowGraphLayoutRequest* layout)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNNewFlowGraphLayoutRequestReference"
        )]
		internal static extern IntPtr BNNewFlowGraphLayoutRequestReference(
			
			// BNFlowGraphLayoutRequest* layout
		    IntPtr layout  
		);
	}
}