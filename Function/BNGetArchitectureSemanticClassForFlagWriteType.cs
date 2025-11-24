using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetArchitectureSemanticClassForFlagWriteType(BNArchitecture* arch, uint32_t writeType)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureSemanticClassForFlagWriteType"
        )]
		internal static extern uint BNGetArchitectureSemanticClassForFlagWriteType(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t writeType
		    uint writeType  
		);
	}
}