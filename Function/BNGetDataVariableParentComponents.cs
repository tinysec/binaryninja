using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNComponent** BNGetDataVariableParentComponents(BNBinaryView* view, uint64_t dataVariable, uint64_t* count)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetDataVariableParentComponents"
        )]
		internal static extern IntPtr BNGetDataVariableParentComponents(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// uint64_t dataVariable
		    ulong dataVariable  , 
			
			// uint64_t* count
		    out ulong count  
		);
	}
}