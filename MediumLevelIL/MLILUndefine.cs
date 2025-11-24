namespace BinaryNinja
{
	public sealed class MLILUndefine : MediumLevelILInstruction
	{
		internal MLILUndefine(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
	}
}
