
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class AnalysisMergeConflictSplitter : AbstractSafeHandle
	{
		internal AnalysisMergeConflictSplitter(IntPtr handle)
			:base(handle, false)
		{
			
		}
	    
		internal static AnalysisMergeConflictSplitter? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new AnalysisMergeConflictSplitter(handle);
		}
	    
		internal static AnalysisMergeConflictSplitter MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new AnalysisMergeConflictSplitter(handle);
		}
	}
}