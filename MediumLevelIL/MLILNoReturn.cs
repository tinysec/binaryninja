namespace BinaryNinja
{
	public sealed class MLILNoReturn : MediumLevelILInstruction
	{
		internal MLILNoReturn(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
	}
}
