namespace BinaryNinja
{
	public sealed class MLILUnimplementedMemory : MediumLevelILInstruction
	{
		internal MLILUnimplementedMemory(
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
	}
}
