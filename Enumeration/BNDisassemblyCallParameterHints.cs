using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum DisassemblyCallParameterHints : uint
	{
		/// <summary>
		/// 
		/// </summary>
		NeverShowMatchingParameterHints = 0,
		
		/// <summary>
		/// 
		/// </summary>
		AlwaysShowParameterHints = 1,
		
		/// <summary>
		/// 
		/// </summary>
		NeverShowParameterHints = 2
	}
}