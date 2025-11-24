namespace BinaryNinja
{
	public sealed class LLILSetRegisterSSA : LowLevelILInstruction
	{
		internal LLILSetRegisterSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILSSARegister Destination
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
	}
}
