using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNRelocationInfo BNRelocationGetInfo(BNRelocation* reloc)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRelocationGetInfo"
        )]
		internal static extern BNRelocationInfo BNRelocationGetInfo(
			
			// BNRelocation* reloc
		    IntPtr reloc  
			
		);
	}
}