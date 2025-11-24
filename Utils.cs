using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace BinaryNinja
{
	public static class Utils
	{
		public static bool FlagOn<T>(T flags , T flag)
			where T : IBinaryInteger<T>
		{
			
			return T.Zero != ( flags & flag );
		}
		
		public static bool StrictFlagOn<T>(T flags , T flag)
			where T : IBinaryInteger<T>
		{
			return ( flags & flag ) == flag;
		}
	}
}
