namespace BinaryNinja
{
	public sealed class LLILAnd : LowLevelILInstruction
	{
		internal LLILAnd(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstruction Left
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)0);
			}
		}
		
		public LowLevelILInstruction Right
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
