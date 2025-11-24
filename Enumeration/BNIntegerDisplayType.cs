using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum IntegerDisplayType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		DefaultIntegerDisplayType = 0,
		
		/// <summary>
		/// 
		/// </summary>
		BinaryDisplayType = 1,
		
		/// <summary>
		/// 
		/// </summary>
		SignedOctalDisplayType = 2,
		
		/// <summary>
		/// 
		/// </summary>
		UnsignedOctalDisplayType = 3,
		
		/// <summary>
		/// 
		/// </summary>
		SignedDecimalDisplayType = 4,
		
		/// <summary>
		/// 
		/// </summary>
		UnsignedDecimalDisplayType = 5,
		
		/// <summary>
		/// 
		/// </summary>
		SignedHexadecimalDisplayType = 6,
		
		/// <summary>
		/// 
		/// </summary>
		UnsignedHexadecimalDisplayType = 7,
		
		/// <summary>
		/// 
		/// </summary>
		CharacterConstantDisplayType = 8,
		
		/// <summary>
		/// 
		/// </summary>
		PointerDisplayType = 9,
		
		/// <summary>
		/// 
		/// </summary>
		FloatDisplayType = 10,
		
		/// <summary>
		/// 
		/// </summary>
		DoubleDisplayType = 11,
		
		/// <summary>
		/// 
		/// </summary>
		EnumerationDisplayType = 12,
		
		/// <summary>
		/// 
		/// </summary>
		InvertedCharacterConstantDisplayType = 13
	}
}