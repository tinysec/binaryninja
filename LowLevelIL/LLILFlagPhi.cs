namespace BinaryNinja
{
	public sealed class LLILFlagPhi : LowLevelILInstruction
	{
		internal LLILFlagPhi(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public LowLevelILSSAFlag Destination
		{
			get
			{
				return this.GetOperandAsSSAFlag((OperandIndex)0 , (OperandIndex)1 );
			}
		}
		
		public LowLevelILSSAFlag[] Source
		{
			get
			{
				return this.GetOperandAsSSAFlagList( (OperandIndex)2 );
			}
		}
	}
}
