namespace BinaryNinja
{
	public sealed class MLILNop : MediumLevelILInstruction
	{
		internal MLILNop(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
	}
}
