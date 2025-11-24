namespace BinaryNinja
{
	public sealed class LLILFloatSquareRoot : LowLevelILInstruction
	{
		internal LLILFloatSquareRoot(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
	}
}
