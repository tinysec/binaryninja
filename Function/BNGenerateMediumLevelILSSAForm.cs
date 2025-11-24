using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNGenerateMediumLevelILSSAForm(BNMediumLevelILFunction* func, bool analyzeConditionals, bool handleAliases, BNVariable* knownNotAliases, uint64_t knownNotAliasCount, BNVariable* knownAliases, uint64_t knownAliasCount)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGenerateMediumLevelILSSAForm"
        )]
		internal static extern void BNGenerateMediumLevelILSSAForm(
			
			// BNMediumLevelILFunction* func
		    IntPtr func  , 
			
			// bool analyzeConditionals
		    bool analyzeConditionals  , 
			
			// bool handleAliases
		    bool handleAliases  , 
			
			// BNVariable* knownNotAliases
		    BNVariable[] knownNotAliases  , 
			
			// uint64_t knownNotAliasCount
		    ulong knownNotAliasCount  , 
			
			// BNVariable* knownAliases
		    BNVariable[] knownAliases  , 
			
			// uint64_t knownAliasCount
		    ulong knownAliasCount  
		);
	}
}