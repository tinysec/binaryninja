using System;

namespace BinaryNinja
{
	/// <summary>
	/// 
	/// </summary>
    public enum InstructionTextTokenType : uint
	{
		
		/// <summary>
		/// 
		/// </summary>
		TextToken = 0,
		
		/// <summary>
		/// 
		/// </summary>
		InstructionToken = 1,
		
		/// <summary>
		/// 
		/// </summary>
		OperandSeparatorToken = 2,
		
		/// <summary>
		/// 
		/// </summary>
		RegisterToken = 3,
		
		/// <summary>
		/// 
		/// </summary>
		IntegerToken = 4,
		
		/// <summary>
		/// 
		/// </summary>
		PossibleAddressToken = 5,
		
		/// <summary>
		/// 
		/// </summary>
		BeginMemoryOperandToken = 6,
		
		/// <summary>
		/// 
		/// </summary>
		EndMemoryOperandToken = 7,
		
		/// <summary>
		/// 
		/// </summary>
		FloatingPointToken = 8,
		
		/// <summary>
		/// 
		/// </summary>
		AnnotationToken = 9,
		
		/// <summary>
		/// 
		/// </summary>
		CodeRelativeAddressToken = 10,
		
		/// <summary>
		/// 
		/// </summary>
		ArgumentNameToken = 11,
		
		/// <summary>
		/// 
		/// </summary>
		HexDumpByteValueToken = 12,
		
		/// <summary>
		/// 
		/// </summary>
		HexDumpSkippedByteToken = 13,
		
		/// <summary>
		/// 
		/// </summary>
		HexDumpInvalidByteToken = 14,
		
		/// <summary>
		/// 
		/// </summary>
		HexDumpTextToken = 15,
		
		/// <summary>
		/// 
		/// </summary>
		OpcodeToken = 16,
		
		/// <summary>
		/// 
		/// </summary>
		StringToken = 17,
		
		/// <summary>
		/// 
		/// </summary>
		CharacterConstantToken = 18,
		
		/// <summary>
		/// 
		/// </summary>
		KeywordToken = 19,
		
		/// <summary>
		/// 
		/// </summary>
		TypeNameToken = 20,
		
		/// <summary>
		/// 
		/// </summary>
		FieldNameToken = 21,
		
		/// <summary>
		/// 
		/// </summary>
		NameSpaceToken = 22,
		
		/// <summary>
		/// 
		/// </summary>
		NameSpaceSeparatorToken = 23,
		
		/// <summary>
		/// 
		/// </summary>
		TagToken = 24,
		
		/// <summary>
		/// 
		/// </summary>
		StructOffsetToken = 25,
		
		/// <summary>
		/// 
		/// </summary>
		StructOffsetByteValueToken = 26,
		
		/// <summary>
		/// 
		/// </summary>
		StructureHexDumpTextToken = 27,
		
		/// <summary>
		/// 
		/// </summary>
		GotoLabelToken = 28,
		
		/// <summary>
		/// 
		/// </summary>
		CommentToken = 29,
		
		/// <summary>
		/// 
		/// </summary>
		PossibleValueToken = 30,
		
		/// <summary>
		/// 
		/// </summary>
		PossibleValueTypeToken = 31,
		
		/// <summary>
		/// 
		/// </summary>
		ArrayIndexToken = 32,
		
		/// <summary>
		/// 
		/// </summary>
		IndentationToken = 33,
		
		/// <summary>
		/// 
		/// </summary>
		UnknownMemoryToken = 34,
		
		/// <summary>
		/// 
		/// </summary>
		EnumerationMemberToken = 35,
		
		/// <summary>
		/// 
		/// </summary>
		OperationToken = 36,
		
		/// <summary>
		/// 
		/// </summary>
		BaseStructureNameToken = 37,
		
		/// <summary>
		/// 
		/// </summary>
		BaseStructureSeparatorToken = 38,
		
		/// <summary>
		/// 
		/// </summary>
		BraceToken = 39,
		
		/// <summary>
		/// 
		/// </summary>
		CodeSymbolToken = 64,
		
		/// <summary>
		/// 
		/// </summary>
		DataSymbolToken = 65,
		
		/// <summary>
		/// 
		/// </summary>
		LocalVariableToken = 66,
		
		/// <summary>
		/// 
		/// </summary>
		ImportToken = 67,
		
		/// <summary>
		/// 
		/// </summary>
		AddressDisplayToken = 68,
		
		/// <summary>
		/// 
		/// </summary>
		IndirectImportToken = 69,
		
		/// <summary>
		/// 
		/// </summary>
		ExternalSymbolToken = 70,
		
		/// <summary>
		/// 
		/// </summary>
		StackVariableToken = 71,
		
		/// <summary>
		/// 
		/// </summary>
		AddressSeparatorToken = 72,
		
		/// <summary>
		/// 
		/// </summary>
		CollapsedInformationToken = 73,
		
		/// <summary>
		/// 
		/// </summary>
		CollapseStateIndicatorToken = 74,
		
		/// <summary>
		/// 
		/// </summary>
		NewLineToken = 75
		
	}
}