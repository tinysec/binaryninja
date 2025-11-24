using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetUserCallRegisterStackAdjustment(BNFunction* func, BNArchitecture* arch, uint64_t addr, BNRegisterStackAdjustment* adjust, uint64_t count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNSetUserCallRegisterStackAdjustment"
        )]
		internal static extern void BNSetUserCallRegisterStackAdjustment(
			
			// BNFunction* func
		    IntPtr func  , 
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint64_t addr
		    ulong addr  , 
			
			// BNRegisterStackAdjustment* adjust
		    IntPtr adjust  , 
			
			// uint64_t count
		    ulong count  
			
		);
	}
}