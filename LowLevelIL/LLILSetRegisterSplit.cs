namespace BinaryNinja
{
	public sealed class LLILSetRegisterSplit : LowLevelILInstruction
	{
		internal LLILSetRegisterSplit(
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
				return this.GetOperandAsRegister((OperandIndex)0 );
			}
		}
		
		public Register Low
		{
			get
			{
				return this.GetOperandAsRegister( (OperandIndex)1 );
			}
		}
		
		public LowLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression( (OperandIndex)2 );
			}
		}
	}
}
