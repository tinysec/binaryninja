using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum RegisterValueType : uint
	{
		/// <summary>
		/// 
		/// </summary>
		UndeterminedValue = 0,
		
		/// <summary>
		/// 
		/// </summary>
		EntryValue = 1,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantValue = 2,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantPointerValue = 3,
		
		/// <summary>
		/// 
		/// </summary>
		ExternalPointerValue = 4,
		
		/// <summary>
		/// 
		/// </summary>
		StackFrameOffset = 5,
		
		/// <summary>
		/// 
		/// </summary>
		ReturnAddressValue = 6,
		
		/// <summary>
		/// 
		/// </summary>
		ImportedAddressValue = 7,
		
		/// <summary>
		/// 
		/// </summary>
		SignedRangeValue = 8,
		
		/// <summary>
		/// 
		/// </summary>
		UnsignedRangeValue = 9,
		
		/// <summary>
		/// 
		/// </summary>
		LookupTableValue = 10,
		
		/// <summary>
		/// 
		/// </summary>
		InSetOfValues = 11,
		
		/// <summary>
		/// 
		/// </summary>
		NotInSetOfValues = 12,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantDataValue = 32768,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantDataZeroExtendValue = 32769,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantDataSignExtendValue = 32770,
		
		/// <summary>
		/// 
		/// </summary>
		ConstantDataAggregateValue = 32771
	}
}