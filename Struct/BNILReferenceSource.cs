using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNILReferenceSource 
	{
		/// <summary>
		/// BNFunction* func
		/// </summary>
		internal IntPtr func;
		
		/// <summary>
		/// BNArchitecture* arch
		/// </summary>
		internal IntPtr arch;
		
		/// <summary>
		/// uint64_t addr
		/// </summary>
		internal ulong addr;
		
		/// <summary>
		/// BNFunctionGraphType type
		/// </summary>
		internal FunctionGraphType type;
		
		/// <summary>
		/// uint64_t exprId
		/// </summary>
		internal ulong exprId;
	}

    public class ILReferenceSource : INativeWrapper<BNILReferenceSource>
    {
		public Function? Function { get; set; } = null;
		
		public Architecture? Architecture { get; set; } = null;
		
		public ulong Address { get; set; } = 0;
		
		public FunctionGraphType Type { get; set; } = FunctionGraphType.NormalFunctionGraph;
	
		public ulong ExprId { get; set; } = 0;
		
		public ILReferenceSource() 
		{
		    
		}

		internal static ILReferenceSource FromNative(BNILReferenceSource native)
		{
			return new ILReferenceSource()
			{
				Function = Function.NewFromHandle(native.func) ,
				Architecture = Architecture.FromHandle(native.arch) ,
				Address = native.addr ,
				Type = native.type ,
				ExprId = native.exprId
			};
		}

		public BNILReferenceSource ToNative()
		{
			return new BNILReferenceSource()
			{
				func = ( null == this.Function ? IntPtr.Zero : this.Function.DangerousGetHandle() ) ,
				arch = ( null == this.Architecture ? IntPtr.Zero : this.Architecture.DangerousGetHandle() ) ,
				addr = this.Address ,
				type = this.Type ,
				exprId = this.ExprId
			};
		}
    }
}