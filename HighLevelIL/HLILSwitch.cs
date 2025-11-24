namespace BinaryNinja
{
	public sealed class HLILSwitch : HighLevelILInstruction
	{
		internal HLILSwitch(
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
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public HighLevelILInstruction Default
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public HighLevelILInstruction[] Cases
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)2);
			}
		}
	}
}
