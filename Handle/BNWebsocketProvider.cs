using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class WebsocketProvider : AbstractSafeHandle<WebsocketClient>
	{
		internal WebsocketProvider(IntPtr handle)
			:base(handle , false)
		{
			
		}
	}
}