using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class MLILIntrinsicSSA : MediumLevelILInstruction
	{
		internal MLILIntrinsicSSA(
			MediumLevelILFunction ilFunction, 
			MediumLevelILExpressionIndex expressionIndex ,
			BNMediumLevelILInstruction native
		) :base(ilFunction, expressionIndex , native)
		{
			
		}
		
		public MediumLevelILSSAVariable[] Output
		{
			get
			{
				return this.GetOperandAsSSAVariableList(0);
			}
		}
		
		public Intrinsic Intrinsic
		{
			get
			{
				return this.GetOperandAsIntrinsic((OperandIndex)2);
			}
		}
		
		public MediumLevelILInstruction[] Parameters
		{
			get
			{
				return this.GetOperandAsExpressionList((OperandIndex)3);
			}
		}

		public override MediumLevelILVariable[] VariablesRead
		{
			get
			{
				List<MediumLevelILVariable> variables = new List<MediumLevelILVariable>();

				foreach (MediumLevelILInstruction parameter in Parameters)
				{
					variables.AddRange( parameter.VariablesRead );
				}

				return variables.ToArray();
			}
		}
		
		public override MediumLevelILSSAVariable[] SSAVariablesRead
		{
			get
			{
				List<MediumLevelILSSAVariable> variables = new List<MediumLevelILSSAVariable>();

				foreach (MediumLevelILInstruction parameter in Parameters)
				{
					variables.AddRange( parameter.SSAVariablesRead );
				}

				return variables.ToArray();
			}
		}
	}
}
