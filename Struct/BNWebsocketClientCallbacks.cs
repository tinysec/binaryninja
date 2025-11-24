using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNWebsocketClientCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** destroyClient
		/// </summary>
		public IntPtr destroyClient;
		
		/// <summary>
		/// void** connect
		/// </summary>
		public IntPtr connect;
		
		/// <summary>
		/// void** write
		/// </summary>
		public IntPtr write;
		
		/// <summary>
		/// void** disconnect
		/// </summary>
		public IntPtr disconnect;
	}

    public class WebsocketClientCallbacks 
    {
		public WebsocketClientCallbacks() 
		{
		    
		}
    }
}