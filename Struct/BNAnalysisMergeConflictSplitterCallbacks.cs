using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAnalysisMergeConflictSplitterCallbacks 
	{
		/// <summary>
		/// void* context
		/// </summary>
		public IntPtr context;
		
		/// <summary>
		/// void** getName
		/// </summary>
		public IntPtr getName;
		
		/// <summary>
		/// void** reset
		/// </summary>
		public IntPtr reset;
		
		/// <summary>
		/// void** finished
		/// </summary>
		public IntPtr finished;
		
		/// <summary>
		/// void** canSplit
		/// </summary>
		public IntPtr canSplit;
		
		/// <summary>
		/// void** split
		/// </summary>
		public IntPtr split;
		
		/// <summary>
		/// void** freeName
		/// </summary>
		public IntPtr freeName;
		
		/// <summary>
		/// void** freeKeyList
		/// </summary>
		public IntPtr freeKeyList;
		
		/// <summary>
		/// void** freeConflictList
		/// </summary>
		public IntPtr freeConflictList;
	}

    public class AnalysisMergeConflictSplitterCallbacks 
    {
		
		public AnalysisMergeConflictSplitterCallbacks() 
		{
		    
		}
    }
}