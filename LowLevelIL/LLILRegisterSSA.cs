namespace BinaryNinja
{
	public sealed class LLILRegisterSSA : LowLevelILInstruction
	{
		internal LLILRegisterSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSARegister Source
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)0,(OperandIndex)1);
			}
		}
	}
}
