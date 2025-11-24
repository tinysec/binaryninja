using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNApplyImportedTypes(BNFunction* func, BNSymbol* sym, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNApplyImportedTypes"
        )]
		internal static extern void BNApplyImportedTypes(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNSymbol* sym
		    IntPtr sym  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}