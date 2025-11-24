using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRegisterPluginCommandForHighLevelILInstruction(const char* name, const char* description, void** action, void** isValid, void* context)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterPluginCommandForHighLevelILInstruction"
        )]
		internal static extern void BNRegisterPluginCommandForHighLevelILInstruction(
			
			// const char* name
		    string name  , 
			
			// const char* description
		    string description  , 
			
			// void** action
		    IntPtr action  , 
			
			// void** isValid
		    IntPtr isValid  , 
			
			// void* context
		    IntPtr context  
			
		);
	}
}