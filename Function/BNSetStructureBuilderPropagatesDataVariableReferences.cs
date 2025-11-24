using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSetStructureBuilderPropagatesDataVariableReferences(BNStructureBuilder* s, bool value)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSetStructureBuilderPropagatesDataVariableReferences"
        )]
		internal static extern void BNSetStructureBuilderPropagatesDataVariableReferences(
			
			// BNStructureBuilder* s
		    IntPtr s  , 
			
			// bool _value
		    bool _value  
		);
	}
}