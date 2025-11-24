using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint64_t BNGetRegisterStackAdjustments(BNCallingConvention* cc, uint32_t* returnRegs, uint64_t returnRegCount, BNType* returnType, BNVariable* @params, uint64_t paramCount, BNType** types, uint64_t typeCount, uint32_t** resultRegisters, uint32_t** resultAdjustments)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetRegisterStackAdjustments"
        )]
		internal static extern ulong BNGetRegisterStackAdjustments(
			
			// BNCallingConvention* cc
		    IntPtr cc  , 
			
			// uint32_t* returnRegs
		    IntPtr returnRegs  , 
			
			// uint64_t returnRegCount
		    ulong returnRegCount  , 
			
			// BNType* returnType
		    IntPtr returnType  , 
			
			// BNVariable* _params
		    IntPtr _params  , 
			
			// uint64_t paramCount
		    ulong paramCount  , 
			
			// BNType** types
		    IntPtr types  , 
			
			// uint64_t typeCount
		    ulong typeCount  , 
			
			// uint32_t** resultRegisters
		    IntPtr resultRegisters  , 
			
			// uint32_t** resultAdjustments
		    IntPtr resultAdjustments  
			
		);
	}
}