namespace BinaryNinja
{
	public sealed class HLILDoWhileSSA : HighLevelILInstruction
	{
		internal HLILDoWhileSSA(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Body
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public HighLevelILInstruction ConditionPHI
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public HighLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
