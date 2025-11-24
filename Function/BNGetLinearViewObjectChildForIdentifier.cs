using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNLinearViewObject* BNGetLinearViewObjectChildForIdentifier(BNLinearViewObject* parent, BNLinearViewObjectIdentifier* id)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetLinearViewObjectChildForIdentifier"
        )]
		internal static extern IntPtr BNGetLinearViewObjectChildForIdentifier(
			
			// BNLinearViewObject* parent
		    IntPtr parent  , 
			
			// BNLinearViewObjectIdentifier* id
		    in BNLinearViewObjectIdentifier id  
		);
	}
}