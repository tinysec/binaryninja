using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    public static partial class Core
    {
	    public static string GetSettingsFileName()
	    {
		    return UnsafeUtils.TakeUtf8String(
			    NativeMethods.BNGetSettingsFileName()
		    );
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGetSettingsFileName()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGetSettingsFileName"
	    )]
	    internal static extern IntPtr BNGetSettingsFileName();
    }
}