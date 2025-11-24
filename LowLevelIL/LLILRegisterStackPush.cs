namespace BinaryNinja
{
	public sealed class LLILRegisterStackPush : LowLevelILInstruction
	{
		internal LLILRegisterStackPush(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public RegisterStack Stack
		{
			get
			{
				return this.GetOperandAsRegisterStack(0);
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
	}
}
