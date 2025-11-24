using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static uint GetMinimumCoreABIVersion()
		{
			return NativeMethods.BNGetMinimumCoreABIVersion();
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetMinimumCoreABIVersion()
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetMinimumCoreABIVersion"
        )]
		public static extern uint BNGetMinimumCoreABIVersion();
	}
}