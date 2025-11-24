namespace BinaryNinja
{
	public sealed class LLILSetRegisterSplitSSA : LowLevelILInstruction
	{
		internal LLILSetRegisterSplitSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstruction High
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public LowLevelILInstruction Low
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
