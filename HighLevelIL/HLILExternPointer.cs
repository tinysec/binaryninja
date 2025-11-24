namespace BinaryNinja
{
	public sealed class HLILExternPointer : HighLevelILInstruction
	{
		internal HLILExternPointer(
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
		
		public ulong Offset
		{
			get
			{
				return this.RawOperands[1];
			}
		}
	}
}
