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
	
	public sealed class InstructionBranch :
		IEquatable<InstructionBranch>, 
		IComparable<InstructionBranch>
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
		
		public override bool Equals(object? other)
		{
			return this.Equals(other as InstructionBranch);
		}

		public bool Equals(InstructionBranch? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Type != other.Type)
			{
				return false;
			}

			if (this.Address != other.Address)
			{
				return false;
			}
			
			return this.Architecture == other.Architecture;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<uint,ulong,int>( 
				(uint)this.Type,
				(ulong)this.Address,
				null == this.Architecture ? 0 : this.Architecture.GetHashCode()
			);
		}

		public static bool operator ==(InstructionBranch? left, InstructionBranch? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(InstructionBranch? left, InstructionBranch? right)
		{
			return !(left == right);
		}

		public int CompareTo(InstructionBranch? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Type.CompareTo(other.Type);

			if (0 == result)
			{
				result = this.Address.CompareTo(other.Address);
			}

			if (0 == result)
			{
				if (null == this.Architecture)
				{
					if (null == other.Architecture)
					{
						result = 0;
					}
					else
					{
						result = -1;
					}
				}
				else
				{
					result = this.Architecture.CompareTo(other.Architecture);
				}
			}
			
			return result;
		}
	}
	
    public sealed class InstructionInfo :
	    IEquatable<InstructionInfo>, 
	    IComparable<InstructionInfo>
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
		
		public override bool Equals(object? other)
		{
			return this.Equals(other as InstructionInfo);
		}

		public bool Equals(InstructionInfo? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Length != other.Length)
			{
				return false;
			}
			
			if (this.ArchTransitionByTargetAddr != other.ArchTransitionByTargetAddr)
			{
				return false;
			}
			
			if (this.DelaySlots != other.DelaySlots)
			{
				return false;
			}
			
			if (this.Branches.Length != other.Branches.Length)
			{
				return false;
			}

			for (int i = 0; i < this.Branches.Length; i++)
			{
				if (this.Branches[i] != other.Branches[i])
				{
					return false;
				}
			}
			
			return true;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<ulong,bool,byte,int>( 
				this.Length,
				this.ArchTransitionByTargetAddr,
				this.DelaySlots,
				this.Branches.GetHashCode()
			);
		}

		public static bool operator ==(InstructionInfo? left, InstructionInfo? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(InstructionInfo? left, InstructionInfo? right)
		{
			return !(left == right);
		}

		public int CompareTo(InstructionInfo? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Length.CompareTo(other.Length);

			if (0 == result)
			{
				result = this.ArchTransitionByTargetAddr.CompareTo(other.ArchTransitionByTargetAddr);
			}

			if (0 == result)
			{
				result = this.DelaySlots.CompareTo(other.DelaySlots);
			}

			if (0 == result)
			{
				if (this.Branches.Length <= other.Branches.Length)
				{
					return -1;
				}
				else if (this.Branches.Length > other.Branches.Length)
				{
					return 1;
				}
				else
				{
					for (int i = 0; i < this.Branches.Length; i++)
					{
						int code = this.Branches[i].CompareTo(other.Branches[i]);
						
						if ( code < 0)
						{
							return -1;
						}
						else if ( code > 0 )
						{
							return 1;
						}
						else
						{
							
						}
					}
				}
			}

			return result;
		}
		
    }
}