using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomLanguageRepresentationFunctionType 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** create
		/// </summary>
		public IntPtr create;
		
		/// <summary>
		/// void** isValid
		/// </summary>
		public IntPtr isValid;
		
		/// <summary>
		/// void** getTypePrinter
		/// </summary>
		public IntPtr getTypePrinter;
		
		/// <summary>
		/// void** getTypeParser
		/// </summary>
		public IntPtr getTypeParser;
		
		/// <summary>
		/// void** getLineFormatter
		/// </summary>
		public IntPtr getLineFormatter;
		
		/// <summary>
		/// void** getFunctionTypeTokens
		/// </summary>
		public IntPtr getFunctionTypeTokens;
		
		/// <summary>
		/// void** freeLines
		/// </summary>
		public IntPtr freeLines;
	}

    public class CustomLanguageRepresentationFunctionType 
    {
		
		public CustomLanguageRepresentationFunctionType() 
		{
		    
		}
    }
}