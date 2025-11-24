using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum TypeClass : uint
	{
		/// <summary>
		/// 
		/// </summary>
		VoidTypeClass = 0,
		
		/// <summary>
		/// 
		/// </summary>
		BoolTypeClass = 1,
		
		/// <summary>
		/// 
		/// </summary>
		IntegerTypeClass = 2,
		
		/// <summary>
		/// 
		/// </summary>
		FloatTypeClass = 3,
		
		/// <summary>
		/// 
		/// </summary>
		StructureTypeClass = 4,
		
		/// <summary>
		/// 
		/// </summary>
		EnumerationTypeClass = 5,
		
		/// <summary>
		/// 
		/// </summary>
		PointerTypeClass = 6,
		
		/// <summary>
		/// 
		/// </summary>
		ArrayTypeClass = 7,
		
		/// <summary>
		/// 
		/// </summary>
		FunctionTypeClass = 8,
		
		/// <summary>
		/// 
		/// </summary>
		VarArgsTypeClass = 9,
		
		/// <summary>
		/// 
		/// </summary>
		ValueTypeClass = 10,
		
		/// <summary>
		/// 
		/// </summary>
		NamedTypeReferenceClass = 11,
		
		/// <summary>
		/// 
		/// </summary>
		WideCharTypeClass = 12
	}
}