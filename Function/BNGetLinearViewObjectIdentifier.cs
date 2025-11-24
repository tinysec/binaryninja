using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObjectIdentifier BNGetLinearViewObjectIdentifier(BNLinearViewObject* obj)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectIdentifier"
        )]
		internal static extern BNLinearViewObjectIdentifier BNGetLinearViewObjectIdentifier(
			
			// BNLinearViewObject* obj
		    IntPtr obj  
		);
	}
}