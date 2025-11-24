using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNVariable BNFromVariableIdentifier(uint64_t id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNFromVariableIdentifier"
        )]
		internal static extern BNVariable BNFromVariableIdentifier(
			
			// uint64_t id
		    ulong id  
		);
	}
}