namespace BinaryNinja
{
	public sealed class MLILBreakpoint : MediumLevelILInstruction
	{
		internal MLILBreakpoint(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
	}
}
