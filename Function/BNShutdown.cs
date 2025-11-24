using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
    {
	    public static void Shutdown()
	    {
		    NativeMethods.BNShutdown();
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// void BNShutdown()
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNShutdown"
	    )]
	    internal static extern void BNShutdown();
    }
}