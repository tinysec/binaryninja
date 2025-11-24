namespace BinaryNinja
{
	public sealed class LLILTailCallSSA : LowLevelILInstruction
	{
		internal LLILTailCallSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSARegister[] Output
		{
			get
			{
				LLILCallOutputSSA? instruction = this.GetOperandAsExpression(0) as LLILCallOutputSSA;

				return instruction!.Destination;
			}
		}
		
		public LowLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public LowLevelILInstruction Stack
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)2);
			}
		}
		
		public LLILCallParameter Parameter
		{
			get
			{
				LLILCallParameter? instruction = this.GetOperandAsExpression((OperandIndex)3) as LLILCallParameter;

				return instruction!;
			}
		}
		
		public LowLevelILInstruction[] Parameters
		{
			get
			{
				LLILCallParameter? instruction = this.GetOperandAsExpression((OperandIndex)3) as LLILCallParameter;

				return instruction!.Source;
			}
		}
	}
}
