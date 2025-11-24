using System;

namespace BinaryNinja
{
	public sealed class LLILFloatConst : LowLevelILInstruction
	{
		internal LLILFloatConst(
			LowLevelILFunction function ,
			LowLevelILExpressionIndex expressionIndex ,
			BNLowLevelILInstruction native
		) : base(function , expressionIndex , native)
		{
			
		}
		
		public double Constant
		{
			get
			{
				return BitConverter.UInt64BitsToDouble(
					this.RawOperands[0]
				);
			}
		}
	}
}
