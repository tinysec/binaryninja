using System;

namespace BinaryNinja
{
	public delegate bool MatchTextDelegate
	(
		ulong address ,
		string text,
		LinearDisassemblyLine line
	);
	
	internal static partial class NativeDelegates
	{
		// bool (*matchCallback)(void* matchCtxt, uint64_t addr, const char* match, BNLinearDisassemblyLine* line)
		public delegate bool MatchTextDelegate(
			IntPtr matchCtxt,
			ulong address,
			IntPtr match ,
			IntPtr line
		);
	}
	
	internal static partial class UnsafeUtils
	{
		internal static NativeDelegates.MatchTextDelegate WrapMatchTextDelegate(
			MatchTextDelegate callback)
		{
			return bool (matchCtxt , address , text , line) =>
			{
				return callback (
					address , 
					UnsafeUtils.ReadUtf8String(text),
					LinearDisassemblyLine.MustFromNativePointer(line)
				);
			};
		}
	}
}
