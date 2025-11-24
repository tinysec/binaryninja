using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNWebsocketProviderCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** createClient
		/// </summary>
		public IntPtr createClient;
	}

    public class WebsocketProviderCallbacks 
    {
		public WebsocketProviderCallbacks() 
		{
		    
		}
    }
}