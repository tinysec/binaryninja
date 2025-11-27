namespace BinaryNinja
{
	public sealed class LLILRegister : LowLevelILInstruction
	{
		internal LLILRegister(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public Register Source
		{
			get
			{
				return this.GetOperandAsRegister(0);
			}
		}
	}
}
