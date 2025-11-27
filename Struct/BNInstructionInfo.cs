using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNInstructionInfo
	{
		/// <summary>
		/// 
		/// uint64_t length
		/// </summary>
		internal ulong length;
		
		/// <summary>
		/// 
		/// uint64_t branchCount
		/// </summary>
		internal ulong branchCount;
		
		/// <summary>
		/// 
		/// bool archTransitionByTargetAddr
		/// </summary>
		internal bool archTransitionByTargetAddr;
		
		/// <summary>
		/// 
		/// uint8_t delaySlots
		/// </summary>
		internal byte delaySlots;
		
		/// <summary>
		/// 
		/// BNBranchType[3] branchType
		/// </summary>
		internal fixed uint branchType[3];
		
		/// <summary>
		/// 
		/// uint64_t[3] branchTarget
		/// </summary>
		internal fixed ulong branchTarget[3];

		/// <summary>
		/// 
		/// BNArchitecture*[3] branchArch
		/// </summary>
		internal IntPtr branchArch_0;
		internal IntPtr branchArch_1;
		internal IntPtr branchArch_2;
	}
	
	public sealed class InstructionBranch
	{
		public BranchType Type { get; } = BranchType.UnconditionalBranch;

		public ulong Address { get; } = 0;
		
		public Architecture? Architecture { get; } = null;

		public InstructionBranch(
			BranchType type ,
			ulong address ,
			Architecture? arch
		)
		{
			this.Type = type;
			this.Address = address;
			this.Architecture = arch;
		}
	}
	
    public sealed class InstructionInfo 
    {	
		public ulong Length { get;} = 0;
		
		public bool ArchTransitionByTargetAddr { get;} = false;
	
		public byte DelaySlots { get; } = 0;
		
		public InstructionBranch[] Branches { get;} = Array.Empty<InstructionBranch>();

		public InstructionInfo() 
		{
			
		}
		
		public InstructionInfo(BNInstructionInfo native)
		{
			this.Length = native.length;
			
			this.ArchTransitionByTargetAddr = native.archTransitionByTargetAddr;

			this.DelaySlots = native.delaySlots;
			
			this.Branches = new InstructionBranch[native.branchCount];
		
			for (ulong i = 0; i < native.branchCount; i++)
			{
				Architecture? arch  = null;
			
				if ( 0 == i)
				{
					arch = Architecture.FromHandle(native.branchArch_0);
				}
				else if ( 1 == i)
				{
					arch = Architecture.FromHandle(native.branchArch_1);
				}
				else if ( 2 ==  i)
				{
					arch = Architecture.FromHandle(native.branchArch_2);
				}

				unsafe
				{
					this.Branches[i] = new InstructionBranch(
						(BranchType)native.branchType[i] ,
						native.branchTarget[i] ,
						arch
					);
				}
			}
		}

		internal static InstructionInfo FromNative(BNInstructionInfo native)
		{
			return new InstructionInfo(native);
		}
    }
}