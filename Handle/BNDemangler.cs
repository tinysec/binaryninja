using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Demangler : AbstractSafeHandle<Demangler>
	{
		internal Demangler(IntPtr handle)
			:base(handle, false)
		{
			
		}
	}
}