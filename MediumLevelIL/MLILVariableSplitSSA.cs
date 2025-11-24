namespace BinaryNinja
{
	public sealed class MLILVariableSplitSSA : MediumLevelILInstruction
	{
		internal MLILVariableSplitSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable High
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)0,(OperandIndex)1);
			}
		}
		
		public MediumLevelILSSAVariable Low
		{
			get
			{
				return this.GetOperandAsSSAVariable((OperandIndex)2,(OperandIndex)3);
			}
		}
	}
}
