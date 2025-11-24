namespace BinaryNinja
{
	public sealed class HLILImport : HighLevelILInstruction
	{
		internal HLILImport(
			HighLevelILFunction ilFunction, 
			HighLevelILExpressionIndex expressionIndex ,
			BNHighLevelILInstruction native
		) : base(ilFunction , expressionIndex, native)
		{
			
		}
		
		public ulong Constant
		{
			get
			{
				return this.RawOperands[0];
			}
		}
	}
}
