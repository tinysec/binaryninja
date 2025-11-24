namespace BinaryNinja
{
	public sealed class MLILLoadStruct : MediumLevelILInstruction
	{
		internal MLILLoadStruct(
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
				return this.GetOperandAsExpression((OperandIndex)1);
			}
		}
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
