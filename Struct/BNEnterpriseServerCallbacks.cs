using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNEnterpriseServerCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** licenseStatusChanged
		/// </summary>
		public IntPtr licenseStatusChanged;
	}

    public class EnterpriseServerCallbacks 
    {
		public EnterpriseServerCallbacks() 
		{
		    
		}
    }
}