namespace BinaryNinja
{
	public sealed class LLILRegisterSplitSSA : LowLevelILInstruction
	{
		internal LLILRegisterSplitSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILSSARegister High
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public LowLevelILSSARegister Low
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)2,(OperandIndex)3);
			}
		}
	}
}
