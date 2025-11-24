using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNFunctionViewType 
	{
		/// <summary>
		/// BNFunctionGraphType type
		/// </summary>
		internal FunctionGraphType type;
		
		/// <summary>
		/// const char* name
		/// </summary>
		internal IntPtr name;
	}

    public sealed class FunctionViewType : INativeWrapperEx<BNFunctionViewType>
    {
		public FunctionGraphType Type { get; set; } = FunctionGraphType.NormalFunctionGraph;
		
		public string Name { get; set; } = string.Empty;
		
		public FunctionViewType() 
		{
		    
		}
		
		public FunctionViewType(FunctionGraphType type, string name = "") 
		{
		    this.Type = type;
		    this.Name = name;
		}

		static FunctionViewType FromNative(BNFunctionViewType native)
		{
			return new FunctionViewType()
			{
				Type = native.type ,
				Name = UnsafeUtils.ReadAnsiString(native.name)
			};
		}

		public BNFunctionViewType ToNativeEx(ScopedAllocator allocator)
		{
			return new BNFunctionViewType()
			{
				type = this.Type , 
				name = allocator.AllocAnsiString(this.Name) ,
			};
		}
    }
}