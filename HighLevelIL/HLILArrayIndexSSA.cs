namespace BinaryNinja
{
	public sealed class HLILArrayIndexSSA : HighLevelILInstruction
	{
		internal HLILArrayIndexSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	
		public HighLevelILInstruction Index
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
