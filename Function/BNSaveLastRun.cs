using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static void SaveLastRun()
		{
			NativeMethods.BNSaveLastRun();
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// void BNSaveLastRun()
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNSaveLastRun"
        )]
		public static extern void BNSaveLastRun();
	}
}