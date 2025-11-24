using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNExternalLocation** BNBinaryViewGetExternalLocations(BNBinaryView* view, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNBinaryViewGetExternalLocations"
        )]
		internal static extern IntPtr BNBinaryViewGetExternalLocations(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t* count
		    IntPtr count  
		);
	}
}