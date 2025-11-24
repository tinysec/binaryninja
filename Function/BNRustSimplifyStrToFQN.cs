using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNRustSimplifyStrToFQN(BNQualifiedName @return, const char* param1, bool param2)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRustSimplifyStrToFQN"
        )]
		internal static extern void BNRustSimplifyStrToFQN(
			
			// BNQualifiedName _return
		    QualifiedName _return  , 
			
			// const char* param1
		    string param1  , 
			
			// bool param2
		    bool param2  
			
		);
	}
}