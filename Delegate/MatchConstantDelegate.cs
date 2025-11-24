using System;

namespace BinaryNinja
{
	public delegate bool MatchConstantDelegate
	(
		ulong address ,
		LinearDisassemblyLine line
	);
	
	internal static partial class NativeDelegates
	{
		// bool (*matchCallback)(void* matchCtxt, uint64_t addr, BNLinearDisassemblyLine* line)
		public delegate bool MatchConstantDelegate(
			IntPtr matchCtxt,
			ulong address,
			IntPtr line
		);
	}
	
	internal static partial class UnsafeUtils
	{
		internal static NativeDelegates.MatchConstantDelegate WrapMatchConstantDelegate(
			MatchConstantDelegate callback)
		{
			return bool (matchCtxt , address , line) =>
			{
				return callback (
					address , 
					LinearDisassemblyLine.MustFromNativePointer(line)
				);
			};
		}
	}
}
