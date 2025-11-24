using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum SymbolDisplayType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		DisplaySymbolOnly = 0,
		
		/// <summary>
		/// 
		/// </summary>
		AddressOfDataSymbols = 1,
		
		/// <summary>
		/// 
		/// </summary>
		DereferenceNonDataSymbols = 2
	}
}