namespace BinaryNinja
{
	public sealed class HLILIf : HighLevelILInstruction
	{
		internal HLILIf(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}

		public HighLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public HighLevelILInstruction TrueBranch
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public HighLevelILInstruction FalseBranch
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
