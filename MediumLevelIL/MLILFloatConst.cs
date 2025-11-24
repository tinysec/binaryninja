using System;

namespace BinaryNinja
{
	public sealed class MLILFloatConst : MediumLevelILInstruction
	{
		internal MLILFloatConst(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
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
