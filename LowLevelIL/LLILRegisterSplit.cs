namespace BinaryNinja
{
	public sealed class LLILRegisterSplit : LowLevelILInstruction
	{
		internal LLILRegisterSplit(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public Register High
		{
			get
			{
				return this.GetOperandAsRegister(0);
			}
		}
		
		public Register Low
		{
			get
			{
				return this.GetOperandAsRegister((OperandIndex)1);
			}
		}
	}
}
