namespace BinaryNinja
{
	public sealed class LLILDivSignedDoublePrecision : LowLevelILInstruction
	{
		internal LLILDivSignedDoublePrecision(
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
