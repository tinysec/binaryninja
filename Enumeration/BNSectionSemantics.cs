using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum SectionSemantics : uint
	{
		/// <summary>
		/// 
		/// </summary>
		DefaultSectionSemantics = 0,
		
		/// <summary>
		/// 
		/// </summary>
		ReadOnlyCodeSectionSemantics = 1,
		
		/// <summary>
		/// 
		/// </summary>
		ReadOnlyDataSectionSemantics = 2,
		
		/// <summary>
		/// 
		/// </summary>
		ReadWriteDataSectionSemantics = 3,
		
		/// <summary>
		/// 
		/// </summary>
		ExternalSectionSemantics = 4
	}
}