using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNDefineImportedFunction(BNBinaryView* view, BNSymbol* importAddressSym, BNFunction* func, BNType* type)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNDefineImportedFunction"
        )]
		internal static extern void BNDefineImportedFunction(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// BNSymbol* importAddressSym
		    IntPtr importAddressSym  , 
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNType* type
		    IntPtr type  
		);
	}
}