using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNRegisterStackInfo 
	{
		/// <summary>
		/// uint32_t firstStorageReg
		/// </summary>
		internal uint firstStorageReg;
		
		/// <summary>
		/// uint32_t firstTopRelativeReg
		/// </summary>
		internal uint firstTopRelativeReg;
		
		/// <summary>
		/// uint32_t storageCount
		/// </summary>
		internal uint storageCount;
		
		/// <summary>
		/// uint32_t topRelativeCount
		/// </summary>
		internal uint topRelativeCount;
		
		/// <summary>
		/// uint32_t stackTopReg
		/// </summary>
		internal uint stackTopReg;
	}

    public sealed class RegisterStackInfo 
    {
		public uint FirstStorageReg { get; } = 0;
		
		public uint FirstTopRelativeReg { get;} = 0;
		
		public uint StorageCount { get; } = 0;

		public uint TopRelativeCount { get;} = 0;

		public uint StackTopReg { get;} = 0;
		
		public RegisterStackInfo() 
		{
		    
		}
		
		public RegisterStackInfo(
			uint firstStorageReg,
			uint firstTopRelativeReg,
			uint storageCount,
			uint topRelativeCount,
			uint stackTopReg
		) 
		{
		    this.FirstStorageReg = firstStorageReg;
		    this.FirstTopRelativeReg = firstTopRelativeReg;
		    this.StorageCount = storageCount;
		    this.TopRelativeCount = topRelativeCount;
		    this.StackTopReg = stackTopReg;
		}

		public RegisterStackInfo(BNRegisterStackInfo native) 
		{
		    this.FirstStorageReg = native.firstStorageReg;
		    this.FirstTopRelativeReg = native.firstTopRelativeReg;
		    this.StorageCount = native.storageCount;
		    this.TopRelativeCount = native.topRelativeCount;
		    this.StackTopReg = native.stackTopReg;
		}
    }
}