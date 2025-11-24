using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNBoolWithConfidence BNIsTypePure(BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNIsTypePure"
        )]
		internal static extern BNBoolWithConfidence BNIsTypePure(
			
			// BNType* type
		    IntPtr type  
			
		);
	}
}