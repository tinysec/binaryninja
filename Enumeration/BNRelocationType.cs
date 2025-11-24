using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum RelocationType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		ELFGlobalRelocationType = 0,
		
		/// <summary>
		/// 
		/// </summary>
		ELFCopyRelocationType = 1,
		
		/// <summary>
		/// 
		/// </summary>
		ELFJumpSlotRelocationType = 2,
		
		/// <summary>
		/// 
		/// </summary>
		StandardRelocationType = 3,
		
		/// <summary>
		/// 
		/// </summary>
		IgnoredRelocation = 4,
		
		/// <summary>
		/// 
		/// </summary>
		UnhandledRelocation = 5
	}
}