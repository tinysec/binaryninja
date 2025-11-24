using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNTypeParserError 
	{
		/// <summary>
		/// BNTypeParserErrorSeverity severity
		/// </summary>
		public TypeParserErrorSeverity severity;
		
		/// <summary>
		/// const char* message
		/// </summary>
		public IntPtr message;
		
		/// <summary>
		/// const char* fileName
		/// </summary>
		public IntPtr fileName;
		
		/// <summary>
		/// uint64_t line
		/// </summary>
		public ulong line;
		
		/// <summary>
		/// uint64_t column
		/// </summary>
		public ulong column;
	}

    public sealed class TypeParserError 
    {
		public TypeParserErrorSeverity Severity { get; set; } = TypeParserErrorSeverity.IgnoredSeverity;
		
		public string Message { get; set; } = string.Empty;
		
		public string FileName { get; set; } = string.Empty;
		
		public ulong Line { get; set; } = 0;
		
		public ulong Column { get; set; } = 0;
		
		public TypeParserError() 
		{
		    
		}

		internal static TypeParserError FromNative(BNTypeParserError raw)
		{
			return new TypeParserError()
			{
				Severity = raw.severity ,
				Message = UnsafeUtils.ReadAnsiString(raw.message) ,
				FileName = UnsafeUtils.ReadAnsiString(raw.fileName) ,
				Line = raw.line ,
				Column = raw.column
			};
		}
    }
}