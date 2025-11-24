namespace BinaryNinja
{
	public sealed class LLILSetRegisterStackRel : LowLevelILInstruction
	{
		internal LLILSetRegisterStackRel(
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
				return this.GetOperandAsRegisterStack((OperandIndex)0 );
			}
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression( (OperandIndex)1 );
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
