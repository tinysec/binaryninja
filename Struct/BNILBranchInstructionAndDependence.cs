using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNILBranchInstructionAndDependence 
	{
		/// <summary>
		/// uint64_t branch
		/// </summary>
		internal ulong branch;
		
		/// <summary>
		/// BNILBranchDependence dependence
		/// </summary>
		internal ILBranchDependence dependence;
	}

    public sealed class ILBranchInstructionAndDependence : INativeWrapper<BNILBranchInstructionAndDependence>
    {
		public ulong Branch { get; set; } = 0;
		
		public ILBranchDependence Dependence { get; set; } = ILBranchDependence.NotBranchDependent;
		
		public ILBranchInstructionAndDependence() 
		{
		    
		}

		internal static ILBranchInstructionAndDependence FromNative(BNILBranchInstructionAndDependence native)
		{
			return new ILBranchInstructionAndDependence()
			{
				Branch = native.branch , 
				Dependence = native.dependence
			};
		}

		public BNILBranchInstructionAndDependence ToNative()
		{
			return new BNILBranchInstructionAndDependence()
			{
				branch = this.Branch , 
				dependence = this.Dependence
			};
		}
    }
}