using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNLineFormatterSettings 
	{
		/// <summary>
		/// BNHighLevelILFunction* highLevelIL
		/// </summary>
		public IntPtr highLevelIL;
		
		/// <summary>
		/// uint64_t desiredLineLength
		/// </summary>
		public ulong desiredLineLength;
		
		/// <summary>
		/// uint64_t minimumContentLength
		/// </summary>
		public ulong minimumContentLength;
		
		/// <summary>
		/// uint64_t tabWidth
		/// </summary>
		public ulong tabWidth;
		
		/// <summary>
		/// uint64_t maximumAnnotationLength
		/// </summary>
		public ulong maximumAnnotationLength;
		
		/// <summary>
		/// uint64_t stringWrappingWidth
		/// </summary>
		public ulong stringWrappingWidth;
		
		/// <summary>
		/// const char* languageName
		/// </summary>
		public IntPtr languageName;
		
		/// <summary>
		/// const char* commentStartString
		/// </summary>
		public IntPtr commentStartString;
		
		/// <summary>
		/// const char* commentEndString
		/// </summary>
		public IntPtr commentEndString;
		
		/// <summary>
		/// const char* annotationStartString
		/// </summary>
		public IntPtr annotationStartString;
		
		/// <summary>
		/// const char* annotationEndString
		/// </summary>
		public IntPtr annotationEndString;
	}

    public sealed class LineFormatterSettings 
    {
		public HighLevelILFunction? HighLevelIL { get; set; } = null;
		
		public ulong DesiredLineLength { get; set; } = 0;
		
		public ulong MinimumContentLength { get; set; } = 0;
		
		public ulong TabWidth { get; set; } = 0;
		
		public ulong MaximumAnnotationLength { get; set; } = 0;
		
		public ulong StringWrappingWidth { get; set; } = 0;
		
		public string LanguageName { get; set; } = string.Empty;
		
		public string CommentStartString { get; set; } = string.Empty;
		
		public string CommentEndString { get; set; } = string.Empty;
		
		public string AnnotationStartString { get; set; } = string.Empty;
	
		public string AnnotationEndString { get; set; } = string.Empty;
		
		public LineFormatterSettings() 
		{
		    
		}
    }
}