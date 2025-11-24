using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum PluginLoadOrder : uint
	{
		/// <summary>
		/// 
		/// </summary>
		EarlyPluginLoadOrder = 0,
		
		/// <summary>
		/// 
		/// </summary>
		NormalPluginLoadOrder = 1,
		
		/// <summary>
		/// 
		/// </summary>
		LatePluginLoadOrder = 2
	}
}