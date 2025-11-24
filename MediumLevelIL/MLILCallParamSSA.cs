namespace BinaryNinja
{
	public sealed class MLILCallParamSSA : MediumLevelILInstruction
	{
		internal MLILCallParamSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[0];
			}
		}
		
		public MediumLevelILInstruction[] Source
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)1);
			}
		}
	}
}
