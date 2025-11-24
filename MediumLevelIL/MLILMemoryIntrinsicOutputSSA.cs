namespace BinaryNinja
{
	public sealed class MLILMemoryIntrinsicOutputSSA : MediumLevelILInstruction
	{
		internal MLILMemoryIntrinsicOutputSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public ulong DestinationMemory
		{
			get
			{
				return (ulong)this.RawOperands[0];
			}
		}
		
		public MediumLevelILSSAVariable[] Output
		{
			get
			{
				return this.GetOperandAsSSAVariableList((OperandIndex)1);
			}
		}
	}
}
