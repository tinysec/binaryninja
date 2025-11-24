using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct BNAnalysisProgress 
	{
		/// <summary>
		/// 
		/// BNAnalysisState state
		/// </summary>
		internal AnalysisState state;
		
		/// <summary>
		/// 
		/// uint64_t count
		/// </summary>
		internal ulong count;
		
		/// <summary>
		/// 
		/// uint64_t total
		/// </summary>
		internal ulong total;
	}
	
    public sealed class AnalysisProgress 
    {
		public AnalysisState State { get; set; } = AnalysisState.InitialState;

		public ulong Count { get; set; } = 0;
		
		public ulong Total { get; set; } = 0;
		
		internal AnalysisProgress( ) 
		{
		    
		}
		
		internal static AnalysisProgress FromNative(BNAnalysisProgress raw )
		{
			return new AnalysisProgress()
			{
				State = raw.state , 
				Count = raw.count ,
				Total = raw.total
			};
		}
    }
}