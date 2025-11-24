namespace BinaryNinja
{
	public sealed class LLILLoad : LowLevelILInstruction
	{
		internal LLILLoad(
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
