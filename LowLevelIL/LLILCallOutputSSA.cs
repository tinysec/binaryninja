namespace BinaryNinja
{
	public sealed class LLILCallOutputSSA : LowLevelILInstruction
	{
		internal LLILCallOutputSSA(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}

		public ulong DestinationMemory
		{
			get
			{
				return this.RawOperands[0];
			}
		}
		
		public LowLevelILSSARegister[] Destination
		{
			get
			{
				return this.GetOperandAsSSARegisterList((OperandIndex)1);
			}
		}
	}
}
