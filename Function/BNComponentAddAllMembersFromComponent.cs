using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNComponentAddAllMembersFromComponent(BNComponent* component, BNComponent* fromComponent)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNComponentAddAllMembersFromComponent"
        )]
		internal static extern void BNComponentAddAllMembersFromComponent(
			
			// BNComponent* component
		    IntPtr component  , 
			
			// BNComponent* fromComponent
		    IntPtr fromComponent  
		);
	}
}