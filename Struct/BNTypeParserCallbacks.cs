using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypeParserCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** getOptionText
		/// </summary>
		public IntPtr getOptionText;
		
		/// <summary>
		/// void** preprocessSource
		/// </summary>
		public IntPtr preprocessSource;
		
		/// <summary>
		/// void** parseTypesFromSource
		/// </summary>
		public IntPtr parseTypesFromSource;
		
		/// <summary>
		/// void** parseTypeString
		/// </summary>
		public IntPtr parseTypeString;
		
		/// <summary>
		/// void** freeString
		/// </summary>
		public IntPtr freeString;
		
		/// <summary>
		/// void** freeResult
		/// </summary>
		public IntPtr freeResult;
		
		/// <summary>
		/// void** freeErrorList
		/// </summary>
		public IntPtr freeErrorList;
	}

    public class TypeParserCallbacks 
    {
		public TypeParserCallbacks() 
		{
		    
		}
    }
}