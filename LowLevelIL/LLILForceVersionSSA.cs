namespace BinaryNinja
{
	public sealed class LLILForceVersionSSA : LowLevelILInstruction
	{
		internal LLILForceVersionSSA(
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
				return this.GetOperandAsSSARegister((OperandIndex)0 , (OperandIndex)1 );
			}
		}
		
		public LowLevelILSSARegister Source
		{
			get
			{
				return this.GetOperandAsSSARegister((OperandIndex)2 , (OperandIndex)3 );
			}
		}
	}
}
