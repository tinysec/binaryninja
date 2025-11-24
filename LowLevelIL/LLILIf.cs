namespace BinaryNinja
{
	public sealed class LLILIf : LowLevelILInstruction
	{
		internal LLILIf(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public LowLevelILInstruction Condition
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public LowLevelILInstruction TrueBranch
		{
			get
			{
				return this.ILFunction.MustGetInstruction(
					(LowLevelILInstructionIndex)this.RawOperands[1]
				);
			}
		}
		
		public LowLevelILInstruction FalseBranch
		{
			get
			{
				return this.ILFunction.MustGetInstruction(
					(LowLevelILInstructionIndex)this.RawOperands[2]
				);
			}
		}
	}
}
