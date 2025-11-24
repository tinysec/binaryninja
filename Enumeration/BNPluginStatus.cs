using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum PluginStatus : uint
	{
		/// <summary>
		/// 
		/// </summary>
		NotInstalledPluginStatus = 0,
		
		/// <summary>
		/// 
		/// </summary>
		InstalledPluginStatus = 1,
		
		/// <summary>
		/// 
		/// </summary>
		EnabledPluginStatus = 2,
		
		/// <summary>
		/// 
		/// </summary>
		UpdateAvailablePluginStatus = 16,
		
		/// <summary>
		/// 
		/// </summary>
		DeletePendingPluginStatus = 32,
		
		/// <summary>
		/// 
		/// </summary>
		UpdatePendingPluginStatus = 64,
		
		/// <summary>
		/// 
		/// </summary>
		DisablePendingPluginStatus = 128,
		
		/// <summary>
		/// 
		/// </summary>
		PendingRestartPluginStatus = 512,
		
		/// <summary>
		/// 
		/// </summary>
		BeingUpdatedPluginStatus = 1024,
		
		/// <summary>
		/// 
		/// </summary>
		BeingDeletedPluginStatus = 2048,
		
		/// <summary>
		/// 
		/// </summary>
		DependenciesBeingInstalledStatus = 4096
	}
}