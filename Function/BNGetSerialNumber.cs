using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public static partial class Core
	{
		public static string GetSerialNumber()
		{
			return UnsafeUtils.TakeAnsiString(
				NativeMethods.BNGetSerialNumber()
			);
		}
	}
	
	internal static partial class NativeMethods
	{
		/// <summary>
		/// const char* BNGetSerialNumber()
		/// </summary>
		[DllImport(
			"binaryninjacore", 
			CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
			EntryPoint = "BNGetSerialNumber"
		)]
		internal static extern IntPtr BNGetSerialNumber();
	}
}