using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class LanguageRepresentationFunctionType : AbstractSafeHandle<LanguageRepresentationFunctionType>
	{
		internal LanguageRepresentationFunctionType(IntPtr handle)
			:base(handle, false)
		{
			
		}

	}
}