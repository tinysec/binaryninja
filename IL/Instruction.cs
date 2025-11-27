using System;
using System.Reflection.Emit;
using System.Text;

namespace BinaryNinja
{
	public sealed class Instruction :
		IEquatable<Instruction>, 
		IComparable<Instruction>
	{
		public ulong Address { get; }
		
		public byte[] Data { get; } = Array.Empty<byte>();
		
		public InstructionInfo Info { get; }
		
		public InstructionTextToken[] Tokens { get; } = Array.Empty<InstructionTextToken>();
		
		public Instruction(
			ulong address,
			byte[] data,
			InstructionInfo info ,
			InstructionTextToken[] tokens 
		)
		{
			this.Address = address;
			this.Data = data;
			this.Info = info;
			this.Tokens = tokens;
		}

		public ulong Length
		{
			get
			{
				return this.Info.Length;
			}
		}

		public string Text
		{
			get
			{
				StringBuilder builder = new StringBuilder();

				foreach (InstructionTextToken token in this.Tokens)
				{
					builder.Append(token.Text);
				}
				
				return builder.ToString();
			}
		}
		
		public override bool Equals(object? other)
		{
			return this.Equals(other as Instruction);
		}

		public bool Equals(Instruction? other)
		{
			if (other is null)
			{
				return false;
			}

			if (ReferenceEquals(this , other))
			{
				return true;
			}

			if (this.Address != other.Address)
			{
				return false;
			}
			
			return true;
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2218:OverrideGetHashCodeOnOverridingEquals")]
		public override int GetHashCode()
		{
			return HashCode.Combine<ulong>( 
				this.Address
			);
		}

		public static bool operator ==(Instruction? left, Instruction? right)
		{
			if (left is null)
			{
				return right is null;
			}
			
			return left.Equals(right);
		}

		public static bool operator !=(Instruction? left, Instruction? right)
		{
			return !(left == right);
		}

		public int CompareTo(Instruction? other)
		{
			if (other is null)
			{
				return 1;
			}
			
			int result = this.Address.CompareTo(other.Address);
			
			return result;
		}
	}
}
