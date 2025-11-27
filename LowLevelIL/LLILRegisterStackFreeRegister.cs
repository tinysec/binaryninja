namespace BinaryNinja
{
	public sealed class LLILRegisterStackFreeRegister : LowLevelILInstruction
	{
		internal LLILRegisterStackFreeRegister(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public Register Destination
		{
			get
			{
				return this.GetOperandAsRegister(0);
			}
		}
	}
}
