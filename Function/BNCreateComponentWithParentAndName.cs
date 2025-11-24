using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNComponent* BNCreateComponentWithParentAndName(BNBinaryView* view, const char* parentGUID, const char* name)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNCreateComponentWithParentAndName"
        )]
		internal static extern IntPtr BNCreateComponentWithParentAndName(
			
			// BNBinaryView* view
		    IntPtr view  , 
			
			// const char* parentGUID
		    string parentGUID  , 
			
			// const char* name
		    string name  
		);
	}
}