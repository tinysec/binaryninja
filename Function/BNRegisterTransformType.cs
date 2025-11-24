using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// BNTransform* BNRegisterTransformType(BNTransformType type, const char* name, const char* longName, const char* group, BNCustomTransform* xform)
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi,
            EntryPoint = "BNRegisterTransformType"
        )]
		internal static extern IntPtr BNRegisterTransformType(
			
			// BNTransformType type
		    TransformType type  , 
			
			// const char* name
		    string name  , 
			
			// const char* longName
		    string longName  , 
			
			// const char* _group
		    string _group  , 
			
			// BNCustomTransform* xform
		    in BNCustomTransform xform  
		);
	}
}