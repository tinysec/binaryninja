using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNRelocationHandlerGetOperandForExternalRelocation(BNRelocationHandler* handler, uint8_t* data, uint64_t addr, uint64_t length, BNLowLevelILFunction* il, BNRelocation* relocation)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRelocationHandlerGetOperandForExternalRelocation"
        )]
		internal static extern ulong BNRelocationHandlerGetOperandForExternalRelocation(
			
			// BNRelocationHandler* handler
		    IntPtr handler  , 
			
			// uint8_t* data
		    IntPtr data  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// uint64_t length
		    ulong length  , 
			
			// BNLowLevelILFunction* il
		    IntPtr il  , 
			
			// BNRelocation* relocation
		    IntPtr relocation  
			
		);
	}
}