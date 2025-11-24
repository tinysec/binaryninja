namespace BinaryNinja
{
	public sealed class LLILRegisterStackRelativeSSA : LowLevelILInstruction
	{
		internal LLILRegisterStackRelativeSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public SSARegisterStack Stack
		{
			get
			{
				return this.GetOperandAsSSARegisterStack((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
		public LowLevelILInstruction Top
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
	}
}
