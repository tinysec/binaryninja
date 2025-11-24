namespace BinaryNinja
{
	public sealed class MLILUnimplemented : MediumLevelILInstruction
	{
		internal MLILUnimplemented(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
	}
}
