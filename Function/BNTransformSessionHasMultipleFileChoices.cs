using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// bool BNTransformSessionHasMultipleFileChoices(BNTransformSession* session)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNTransformSessionHasMultipleFileChoices"
        )]
		internal static extern bool BNTransformSessionHasMultipleFileChoices(
			
			// BNTransformSession* session
		    IntPtr session  
			
		);
	}
}