namespace BinaryNinja
{
	public sealed class MLILLoadSSA : MediumLevelILInstruction
	{
		internal MLILLoadSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction Source
		{
			get
			{
				return this.GetOperandAsExpression(0);
			}
		}
		
		public ulong SourceMemory
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
