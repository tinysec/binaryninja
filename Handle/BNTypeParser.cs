using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class TypeParser : AbstractSafeHandle<TypeParser>
	{
		internal TypeParser(IntPtr handle)
			:base(handle , false)
		{
			
		}
	}
}