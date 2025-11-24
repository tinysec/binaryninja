using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNGetDebugDataVariableByName(BNDebugInfo* debugInfo, const char* parserName, const char* variableName, BNDataVariableAndName* var)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNGetDebugDataVariableByName"
        )]
		internal static extern bool BNGetDebugDataVariableByName(
			
			// BNDebugInfo* debugInfo
		    IntPtr debugInfo  , 
			
			// const char* parserName
		    string parserName  , 
			
			// const char* variableName
		    string variableName  , 
			
			// BNDataVariableAndName* _var
		    IntPtr _var  
			
		);
	}
}