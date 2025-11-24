using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static uint GetBuildId()
		{
			return NativeMethods.BNGetBuildId();
		}
	}
	
    internal static partial class NativeMethods
    {
	    /// <summary>
		/// uint32_t BNGetBuildId()
		/// </summary>
		[DllImport(
            "binaryninjacore", 
            CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint = "BNGetBuildId"
        )]
		internal static extern uint BNGetBuildId();
	}
}