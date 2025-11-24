using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNTransformSessionRequiresUserInput(BNTransformSession* session)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionRequiresUserInput"
        )]
		internal static extern bool BNTransformSessionRequiresUserInput(
			
			// BNTransformSession* session
		    IntPtr session  
			
		);
	}
}