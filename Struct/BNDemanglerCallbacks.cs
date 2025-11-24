using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNDemanglerCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** isMangledString
		/// </summary>
		public IntPtr isMangledString;
		
		/// <summary>
		/// void** demangle
		/// </summary>
		public IntPtr demangle;
		
		/// <summary>
		/// void** freeVarName
		/// </summary>
		public IntPtr freeVarName;
	}

    public class DemanglerCallbacks 
    {
		public DemanglerCallbacks() 
		{
		    
		}
    }
}