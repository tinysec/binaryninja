using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRelocation* BNNewRelocationReference(BNRelocation* reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNNewRelocationReference"
        )]
		internal static extern IntPtr BNNewRelocationReference(
			
			// BNRelocation* reloc
		    IntPtr reloc  
			
		);
	}
}