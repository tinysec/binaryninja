namespace BinaryNinja
{
	public sealed class LLILRegisterStackDestinationSSA : LowLevelILInstruction
	{
		internal LLILRegisterStackDestinationSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public SSARegisterStack Destination
		{
			get
			{
				return this.GetOperandAsSSARegisterStack((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public SSARegisterStack Source
		{
			get
			{
				return this.GetOperandAsSSARegisterStack((OperandIndex)0,(OperandIndex)2);
			}
		}
	}
}
