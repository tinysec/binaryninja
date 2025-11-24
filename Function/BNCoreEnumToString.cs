using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNCoreEnumToString(const char* enumName, uint64_t value, const char** result)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCoreEnumToString"
        )]
		internal static extern bool BNCoreEnumToString(
			
			// const char* enumName
		    string enumName  , 
			
			// uint64_t _value
		    ulong _value  , 
			
			// const char** result
		    string[] result  
		);
	}
}