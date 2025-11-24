namespace BinaryNinja
{
	public sealed class LLILLogicalShiftRight : LowLevelILInstruction
	{
		internal LLILLogicalShiftRight(
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
				return this.GetOperandAsExpression(0);
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
