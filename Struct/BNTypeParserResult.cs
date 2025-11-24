using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNTypeParserResult 
	{
		/// <summary>
		/// BNParsedType* types
		/// </summary>
		internal IntPtr types;
		
		/// <summary>
		/// BNParsedType* variables
		/// </summary>
		internal IntPtr variables;
		
		/// <summary>
		/// BNParsedType* functions
		/// </summary>
		internal IntPtr functions;
		
		/// <summary>
		/// uint64_t typeCount
		/// </summary>
		internal ulong typeCount;
		
		/// <summary>
		/// uint64_t variableCount
		/// </summary>
		internal ulong variableCount;
		
		/// <summary>
		/// uint64_t functionCount
		/// </summary>
		internal ulong functionCount;
	}

    public sealed class TypeParserResult 
    {
		public ParsedType[] Types { get; set; } = Array.Empty<ParsedType>();
		
		public ParsedType[] Variables { get; set; } = Array.Empty<ParsedType>();
		
		public ParsedType[] Functions { get; set; } = Array.Empty<ParsedType>();
		
		public TypeParserResult() 
		{
		    
		}

		internal static TypeParserResult FromNative(BNTypeParserResult native)
		{
			return new TypeParserResult()
			{
				Types = UnsafeUtils.ReadStructArray<BNParsedType , ParsedType>(
					native.types ,
					native.typeCount ,
					ParsedType.FromNative
				) ,
				Variables = UnsafeUtils.ReadStructArray<BNParsedType , ParsedType>(
					native.variables ,
					native.variableCount ,
					ParsedType.FromNative
				) ,
				Functions = UnsafeUtils.ReadStructArray<BNParsedType , ParsedType>(
					native.functions ,
					native.functionCount ,
					ParsedType.FromNative
				) 
			};
		}

		internal static TypeParserResult TakeNative(BNTypeParserResult native)
		{
			TypeParserResult target = TypeParserResult.FromNative(native);

			NativeMethods.BNFreeTypeParserResult(native);
			
			return target;
		}
    }
}