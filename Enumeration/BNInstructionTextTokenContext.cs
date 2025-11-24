using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum InstructionTextTokenContext : uint
	{
		/// <summary>
		/// 
		/// </summary>
		NoTokenContext = 0,
		
		/// <summary>
		/// 
		/// </summary>
		LocalVariableTokenContext = 1,
		
		/// <summary>
		/// 
		/// </summary>
		DataVariableTokenContext = 2,
		
		/// <summary>
		/// 
		/// </summary>
		FunctionReturnTokenContext = 3,
		
		/// <summary>
		/// 
		/// </summary>
		InstructionAddressTokenContext = 4,
		
		/// <summary>
		/// 
		/// </summary>
		ILInstructionIndexTokenContext = 5,
		
		/// <summary>
		/// 
		/// </summary>
		ConstDataTokenContext = 6,
		
		/// <summary>
		/// 
		/// </summary>
		ConstStringDataTokenContext = 7,
		
		/// <summary>
		/// 
		/// </summary>
		StringReferenceTokenContext = 8,
		
		/// <summary>
		/// 
		/// </summary>
		StringDataVariableTokenContext = 9,
		
		/// <summary>
		/// 
		/// </summary>
		StringDisplayTokenContext = 10,
		
		/// <summary>
		/// 
		/// </summary>
		ContentCollapsedContext = 11,
		
		/// <summary>
		/// 
		/// </summary>
		ContentExpandedContext = 12,
		
		/// <summary>
		/// 
		/// </summary>
		ContentCollapsiblePadding = 13
	}
}