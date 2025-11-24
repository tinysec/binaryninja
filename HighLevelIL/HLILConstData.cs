namespace BinaryNinja
{
	public sealed class HLILConstData : HighLevelILInstruction
	{
		internal HLILConstData(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public RegisterValue Constant
		{
			get
			{
				return this.GetOperandAsConstantData(0 , (OperandIndex)1);
			}
		}
	}
}
