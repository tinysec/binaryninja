namespace BinaryNinja
{
	public sealed class HLILConstPointer : HighLevelILInstruction
	{
		internal HLILConstPointer(
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
