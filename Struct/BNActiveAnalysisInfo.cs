using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNActiveAnalysisInfo 
	{
		/// <summary>
		/// BNFunction* func
		/// </summary>
		internal IntPtr func;
		
		/// <summary>
		/// uint64_t analysisTime
		/// </summary>
		internal ulong analysisTime;
		
		/// <summary>
		/// uint64_t updateCount
		/// </summary>
		internal ulong updateCount;
		
		/// <summary>
		/// uint64_t submitCount
		/// </summary>
		internal ulong submitCount;
	}

    public class ActiveAnalysisInfo 
    {
		public Function? Function { get; set; } = null;
		
		public ulong AnalysisTime { get; set; } = 0;
		
		public ulong UpdateCount { get; set; } = 0;
		
		public ulong SubmitCount { get; set; } = 0;
		
		public ActiveAnalysisInfo() 
		{
		    
		}

		internal static ActiveAnalysisInfo FromNativeStructPtr(IntPtr rawPtr)
		{
			return ActiveAnalysisInfo.FromNative( Marshal.PtrToStructure<BNActiveAnalysisInfo>( rawPtr ) );
		}

		internal static ActiveAnalysisInfo FromNative(BNActiveAnalysisInfo raw)
		{
			return new ActiveAnalysisInfo()
			{
				Function = IntPtr.Zero == raw.func ? null : Function.MustNewFromHandle(raw.func),
				AnalysisTime = raw.analysisTime,
				UpdateCount = raw.updateCount,
				SubmitCount = raw.submitCount,
			};
		}
    }
}