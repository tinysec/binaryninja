using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class ScriptingProvider : AbstractSafeHandle<ScriptingInstance>
	{
		internal ScriptingProvider(IntPtr handle)
			:base(handle , false)
		{
			
		}
	}
}