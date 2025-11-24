using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t* BNGetArchitectureFlagsWrittenByFlagWriteType(BNArchitecture* arch, uint32_t writeType, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetArchitectureFlagsWrittenByFlagWriteType"
        )]
		internal static extern IntPtr BNGetArchitectureFlagsWrittenByFlagWriteType(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// uint32_t writeType
		    uint writeType  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}