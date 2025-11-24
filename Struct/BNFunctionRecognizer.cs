using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNFunctionRecognizer 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** recognizeLowLevelIL
		/// </summary>
		public IntPtr recognizeLowLevelIL;
		
		/// <summary>
		/// void** recognizeMediumLevelIL
		/// </summary>
		public IntPtr recognizeMediumLevelIL;
	}

    public class FunctionRecognizer 
    {
		public FunctionRecognizer() 
		{
		    
		}
    }
}