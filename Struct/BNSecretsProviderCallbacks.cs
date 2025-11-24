using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNSecretsProviderCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** hasData
		/// </summary>
		public IntPtr hasData;
		
		/// <summary>
		/// void** getData
		/// </summary>
		public IntPtr getData;
		
		/// <summary>
		/// void** storeData
		/// </summary>
		public IntPtr storeData;
		
		/// <summary>
		/// void** deleteData
		/// </summary>
		public IntPtr deleteData;
	}

    public class SecretsProviderCallbacks 
    {
		public SecretsProviderCallbacks() 
		{
		    
		}
    }
}