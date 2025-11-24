using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAnalysisInfo 
	{
		/// <summary>
		/// BNAnalysisState state
		/// </summary>
		public AnalysisState state;
		
		/// <summary>
		/// uint64_t analysisTime
		/// </summary>
		public ulong analysisTime;
		
		/// <summary>
		/// BNActiveAnalysisInfo* activeInfo
		/// </summary>
		public IntPtr activeInfo;
		
		/// <summary>
		/// uint64_t count
		/// </summary>
		public ulong count;
	}

    public class AnalysisInfo 
    {
		public AnalysisState State { get; set; } = AnalysisState.InitialState;
		
		public ulong AnalysisTime { get; set; } = 0;
		
		public ActiveAnalysisInfo? ActiveInfo { get; set; } = null;
		
		public ulong Count { get; set; } = 0;
		
		public AnalysisInfo() 
		{
		    
		}
		
		internal static AnalysisInfo MustTakeNativePointer(IntPtr pointer)
		{
			AnalysisInfo target = AnalysisInfo.MustFromNativePointer(pointer);

			NativeMethods.BNFreeAnalysisInfo(pointer);
			
			return target;
		}

		internal static AnalysisInfo MustFromNativePointer(IntPtr rawPtr)
		{
			if (IntPtr.Zero == rawPtr)
			{
				throw new ArgumentNullException(nameof(rawPtr));
			}
			
			return AnalysisInfo.FromNative(Marshal.PtrToStructure<BNAnalysisInfo>(rawPtr));
		}

		internal static AnalysisInfo FromNative(BNAnalysisInfo raw)
		{
			return new AnalysisInfo()
			{
				State = raw.state ,
				AnalysisTime = raw.analysisTime ,
				ActiveInfo = ( IntPtr.Zero == raw.activeInfo ? null : ActiveAnalysisInfo.FromNativeStructPtr(raw.activeInfo) ) ,
				Count = raw.count
			};
		}
    }
}