namespace BinaryNinja
{
	public sealed class LLILRegisterStackPop : LowLevelILInstruction
	{
		internal LLILRegisterStackPop(
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
	}
}
