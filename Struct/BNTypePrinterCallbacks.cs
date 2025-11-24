using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypePrinterCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** getTypeTokens
		/// </summary>
		public IntPtr getTypeTokens;
		
		/// <summary>
		/// void** getTypeTokensBeforeName
		/// </summary>
		public IntPtr getTypeTokensBeforeName;
		
		/// <summary>
		/// void** getTypeTokensAfterName
		/// </summary>
		public IntPtr getTypeTokensAfterName;
		
		/// <summary>
		/// void** getTypeString
		/// </summary>
		public IntPtr getTypeString;
		
		/// <summary>
		/// void** getTypeStringBeforeName
		/// </summary>
		public IntPtr getTypeStringBeforeName;
		
		/// <summary>
		/// void** getTypeStringAfterName
		/// </summary>
		public IntPtr getTypeStringAfterName;
		
		/// <summary>
		/// void** getTypeLines
		/// </summary>
		public IntPtr getTypeLines;
		
		/// <summary>
		/// void** printAllTypes
		/// </summary>
		public IntPtr printAllTypes;
		
		/// <summary>
		/// void** freeTokens
		/// </summary>
		public IntPtr freeTokens;
		
		/// <summary>
		/// void** freeString
		/// </summary>
		public IntPtr freeString;
		
		/// <summary>
		/// void** freeLines
		/// </summary>
		public IntPtr freeLines;
		
	}

    public class TypePrinterCallbacks 
    {
		public TypePrinterCallbacks() 
		{
		    
		}
    }
}