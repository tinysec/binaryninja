namespace BinaryNinja
{
	public sealed class HLILMemoryPhi : HighLevelILInstruction
	{
		internal HLILMemoryPhi(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public ulong Destination
		{
			get
			{
				return this.RawOperands[0];
			}
		}
		
		public ulong[] Source
		{
			get
			{
				return this.GetOperandAsIntegerArray<ulong>((OperandIndex)1);
			}
		}
	}
}
