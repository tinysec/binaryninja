using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static uint GetCurrentCoreABIVersion()
		{
			return NativeMethods.BNGetCurrentCoreABIVersion();
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetCurrentCoreABIVersion()
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetCurrentCoreABIVersion"
        )]
		public static extern uint BNGetCurrentCoreABIVersion();
	}
}