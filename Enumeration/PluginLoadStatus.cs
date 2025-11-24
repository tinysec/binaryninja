using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum PluginLoadStatus : uint
	{
		/// <summary>
		/// 
		/// </summary>
		NotAttemptedStatus = 0,
		
		/// <summary>
		/// 
		/// </summary>
		LoadSucceededStatus = 1,
		
		/// <summary>
		/// 
		/// </summary>
		LoadFailedStatus = 2
	}
}