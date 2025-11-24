using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class DownloadProvider : AbstractSafeHandle<DownloadProvider>
	{
		internal DownloadProvider(IntPtr handle)
			:base(handle , false)
		{
			
		}
	}
}