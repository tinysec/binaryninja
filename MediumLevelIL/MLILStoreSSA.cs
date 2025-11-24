namespace BinaryNinja
{
	public sealed class MLILStoreSSA : MediumLevelILInstruction
	{
		internal MLILStoreSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Destination
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public ulong DestinationMemory
		{
			get
			{
				return this.RawOperands[1];
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[2];
			}
		}
		
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression((OperandIndex)3);
			}
		}
	}
}
