namespace BinaryNinja
{
	public sealed class HLILFor : HighLevelILInstruction
	{
		internal HLILFor(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public HighLevelILInstruction Init
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public HighLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public HighLevelILInstruction Update
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
		public HighLevelILInstruction Body
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
	}
}
