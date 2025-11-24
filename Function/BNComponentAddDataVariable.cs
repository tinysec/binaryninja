using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNComponentAddDataVariable(BNComponent* component, uint64_t address)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentAddDataVariable"
        )]
		internal static extern bool BNComponentAddDataVariable(
			
			// BNComponent* component
		    IntPtr component  , 
			
			// uint64_t address
		    ulong address  
		);
	}
}