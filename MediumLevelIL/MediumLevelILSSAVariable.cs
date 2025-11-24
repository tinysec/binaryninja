using System;
using System.Collections.Generic;

namespace BinaryNinja
{
	public sealed class MediumLevelILSSAVariable : AbstractSSAVariable<MediumLevelILVariable>
	{
		public MediumLevelILSSAVariable(MediumLevelILVariable variable , ulong version) 
			:base(variable, version)
		{
			
		}

		public MediumLevelILInstruction? Definition
		{
			get
			{
				return this.Variable.ILFunction.GetExpression(
					NativeMethods.BNGetMediumLevelILSSAVarDefinition(
						this.Variable.ILFunction.DangerousGetHandle() ,
						this.Variable.ToNative() ,
						this.Version
					)
				);
			}
		}
		
		public MediumLevelILInstruction[] Uses
		{
			get
			{
				IntPtr arrayPointer = NativeMethods.BNGetMediumLevelILSSAVarUses(
					this.Variable.ILFunction.DangerousGetHandle() ,
					this.Variable.ToNative() ,
					this.Version ,
					out ulong arrayLength
				);

				ulong[] indexes = UnsafeUtils.TakeNumberArray<ulong>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreeILInstructionList
				);
		    
				List<MediumLevelILInstruction>  instructions = new List<MediumLevelILInstruction>();

				foreach (MediumLevelILExpressionIndex index in indexes)
				{
					instructions.Add(
						this.Variable.ILFunction.MustGetExpression(index)
					);
				}
		    
				return instructions.ToArray();
			}
		}

		public RegisterValue Value
		{
			get
			{
				return RegisterValue.FromNative(
					NativeMethods.BNGetMediumLevelILSSAVarValue(
						this.Variable.ILFunction.DangerousGetHandle() ,
						this.Variable.ToNative() ,
						this.Version
					)
				);
			}
		}
		
		public PossibleValueSet GetPossibleValues(
			MediumLevelILInstructionIndex instruction ,
			DataFlowQueryOption[] options
		)
		{
			return PossibleValueSet.TakeNative(
				NativeMethods.BNGetMediumLevelILPossibleSSAVarValues(
					this.Variable.ILFunction.DangerousGetHandle() , 
					this.Variable.ToNative(),
					this.Version ,
					instruction,
					options,
					(ulong)options.Length
				)
			);
		}
		
		public bool IsLiveAt(MediumLevelILInstructionIndex instruction)
		{
			return NativeMethods.BNIsMediumLevelILSSAVarLiveAt(
				this.Variable.ILFunction.DangerousGetHandle() ,
				this.Variable.ToNative() ,
				this.Version,
				instruction
			);
		}
	}
}
