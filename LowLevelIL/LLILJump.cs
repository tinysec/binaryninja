namespace BinaryNinja
{
	public sealed class LLILJump : LowLevelILInstruction
	{
		internal LLILJump(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
