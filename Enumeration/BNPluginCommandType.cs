using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum PluginCommandType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		DefaultPluginCommand = 0,
		
		/// <summary>
		/// 
		/// </summary>
		AddressPluginCommand = 1,
		
		/// <summary>
		/// 
		/// </summary>
		RangePluginCommand = 2,
		
		/// <summary>
		/// 
		/// </summary>
		FunctionPluginCommand = 3,
		
		/// <summary>
		/// 
		/// </summary>
		LowLevelILFunctionPluginCommand = 4,
		
		/// <summary>
		/// 
		/// </summary>
		LowLevelILInstructionPluginCommand = 5,
		
		/// <summary>
		/// 
		/// </summary>
		MediumLevelILFunctionPluginCommand = 6,
		
		/// <summary>
		/// 
		/// </summary>
		MediumLevelILInstructionPluginCommand = 7,
		
		/// <summary>
		/// 
		/// </summary>
		HighLevelILFunctionPluginCommand = 8,
		
		/// <summary>
		/// 
		/// </summary>
		HighLevelILInstructionPluginCommand = 9,
		
		/// <summary>
		/// 
		/// </summary>
		ProjectPluginCommand = 10
	}
}