namespace BinaryNinja
{
	public sealed class MLILMemoryPhi : MediumLevelILInstruction
	{
		internal MLILMemoryPhi(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
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
