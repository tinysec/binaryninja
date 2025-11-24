using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNAddArchitectureRedirection(BNArchitecture* arch, BNArchitecture* from, BNArchitecture* to)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNAddArchitectureRedirection"
        )]
		internal static extern void BNAddArchitectureRedirection(
			
			// BNArchitecture* arch
		    IntPtr arch  , 
			
			// BNArchitecture* _from
		    IntPtr _from  , 
			
			// BNArchitecture* to
		    IntPtr to  
		);
	}
}