namespace BinaryNinja
{
	public sealed class LLILAssertSSA : LowLevelILInstruction
	{
		internal LLILAssertSSA(
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
				return this.GetOperandAsSSARegister((OperandIndex)0 , (OperandIndex)1);
			}
		}
		
		public PossibleValueSet Constraint
		{
			get
			{
				return this.GetOperandAsPossibleValueSet((OperandIndex)2);
			}
		}
	}
}
