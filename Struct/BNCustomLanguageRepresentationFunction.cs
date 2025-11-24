using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNCustomLanguageRepresentationFunction 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** freeObject
		/// </summary>
		public IntPtr freeObject;
		
		/// <summary>
		/// void** externalRefTaken
		/// </summary>
		public IntPtr externalRefTaken;
		
		/// <summary>
		/// void** externalRefReleased
		/// </summary>
		public IntPtr externalRefReleased;
		
		/// <summary>
		/// void** initTokenEmitter
		/// </summary>
		public IntPtr initTokenEmitter;
		
		/// <summary>
		/// void** getExprText
		/// </summary>
		public IntPtr getExprText;
		
		/// <summary>
		/// void** beginLines
		/// </summary>
		public IntPtr beginLines;
		
		/// <summary>
		/// void** endLines
		/// </summary>
		public IntPtr endLines;
		
		/// <summary>
		/// void** getCommentStartString
		/// </summary>
		public IntPtr getCommentStartString;
		
		/// <summary>
		/// void** getCommentEndString
		/// </summary>
		public IntPtr getCommentEndString;
		
		/// <summary>
		/// void** getAnnotationStartString
		/// </summary>
		public IntPtr getAnnotationStartString;
		
		/// <summary>
		/// void** getAnnotationEndString
		/// </summary>
		public IntPtr getAnnotationEndString;
	}

    public class CustomLanguageRepresentationFunction 
    {
		public CustomLanguageRepresentationFunction() 
		{
		    
		}
    }
}