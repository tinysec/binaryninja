using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRepository* BNNewRepositoryReference(BNRepository* r)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewRepositoryReference"
        )]
		internal static extern IntPtr BNNewRepositoryReference(
			
			// BNRepository* r
		    IntPtr r  
			
		);
	}
}