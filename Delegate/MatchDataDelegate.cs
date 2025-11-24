using System;

namespace BinaryNinja
{
	public delegate bool MatchDataDelegate
	(
		ulong address ,
		byte[] data
	);
	
	internal static partial class NativeDelegates
	{
		// bool (*matchCallback)(void* matchCtxt, uint64_t addr, BNDataBuffer* match)
		public delegate bool MatchDataDelegate(
			IntPtr matchCtxt,
			ulong address,
			IntPtr match
		);
	}
	
	internal static partial class UnsafeUtils
	{
		internal static NativeDelegates.MatchDataDelegate WrapMatchDataDelegate(
			MatchDataDelegate callback)
		{
			return bool (matchCtxt , address , buffer) =>
			{
				return callback(
					address , 
					DataBuffer.MustBorrowHandle(buffer).Contents
				);
			};
		}
	}
}
