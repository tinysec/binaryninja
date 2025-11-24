namespace BinaryNinja
{
	public sealed class HLILFloatConst : HighLevelILInstruction
	{
		internal HLILFloatConst(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public double Constant
		{
			get
			{
				return this.GetOperandAsDouble(0);
			}
		}
	}
}
