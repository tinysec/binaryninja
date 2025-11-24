using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum SaveOption : uint
	{
		/// <summary>
		/// 
		/// </summary>
		RemoveUndoData = 0,
		
		/// <summary>
		/// 
		/// </summary>
		TrimSnapshots = 1,
		
		/// <summary>
		/// 
		/// </summary>
		PurgeOriginalFilenamePath = 2
	}
}