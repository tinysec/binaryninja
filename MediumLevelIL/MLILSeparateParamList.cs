namespace BinaryNinja
{
	public sealed class MLILSeparateParamList : MediumLevelILInstruction
	{
		internal MLILSeparateParamList(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList(0);
			}
		}
	}
}
