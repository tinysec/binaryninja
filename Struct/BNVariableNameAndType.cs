using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNVariableNameAndType 
	{
		/// <summary>
		/// BNVariable _var
		/// </summary>
		internal BNVariable variable;
		
		/// <summary>
		/// BNType* type
		/// </summary>
		internal IntPtr type;
		
		/// <summary>
		/// const char* name
		/// </summary>
		internal IntPtr name;
		
		/// <summary>
		/// bool autoDefined
		/// </summary>
		internal bool autoDefined;
		
		/// <summary>
		/// uint8_t typeConfidence
		/// </summary>
		internal byte typeConfidence;
	}
	
	public abstract class AbstractVariableNameAndType<T_VARIABLE>
		where T_VARIABLE : AbstractVariable
	{
		public T_VARIABLE variable { get; }
		
		public BinaryNinja.Type Type { get;  }
		
		public string Name { get;  } = string.Empty;
		
		public bool AutoDefined { get;  } = false;
		
		public byte TypeConfidence { get;  } = 0;
		
		internal AbstractVariableNameAndType(
			T_VARIABLE variable,
			BNVariableNameAndType native
		) 
		{
			this.variable = variable;
			this.Type = BinaryNinja.Type.MustNewFromHandle(native.type);
			this.Name = UnsafeUtils.ReadAnsiString(native.name);
			this.AutoDefined = native.autoDefined;
			this.TypeConfidence = native.typeConfidence;
		}

		public BNVariableNameAndType ToNative(ScopedAllocator allocator)
		{
			return new BNVariableNameAndType()
			{
				variable = this.variable.ToNative() ,
				type = this.Type.DangerousGetHandle() ,
				name = allocator.AllocAnsiString(this.Name) ,
				autoDefined = this.AutoDefined ,
				typeConfidence = this.TypeConfidence
			};
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
	
    public class CoreVariableNameAndType : AbstractVariableNameAndType<CoreVariable>
    {
		internal CoreVariableNameAndType(BNVariableNameAndType native) 
			:base(CoreVariable.FromNative(native.variable) , native)
		{
		    
		}

		internal static CoreVariableNameAndType FromNative(BNVariableNameAndType native)
		{
			return new CoreVariableNameAndType(native);
		}
    }
    
    public class VariableNameAndType 
    {
	    public Variable variable { get; set; }
		
	    public BinaryNinja.Type Type { get; set; }
		
	    public string Name { get; set; } = string.Empty;
		
	    public bool AutoDefined { get; set; } = false;
		
	    public byte TypeConfidence { get; set; } = 0;
		
	    internal VariableNameAndType(Function function ,BNVariableNameAndType native) 
	    {
		    this.variable = Variable.FromNativeEx(function , native.variable);
		    this.Type = BinaryNinja.Type.MustNewFromHandle(native.type);
		    this.Name = UnsafeUtils.ReadAnsiString(native.name);
		    this.AutoDefined = native.autoDefined;
		    this.TypeConfidence = native.typeConfidence;
	    }

	    internal static VariableNameAndType FromNativeEx(Function function ,BNVariableNameAndType native)
	    {
		    return new VariableNameAndType(function , native);
	    }

	    public BNVariableNameAndType ToNative(ScopedAllocator allocator)
	    {
		    return new BNVariableNameAndType()
		    {
			    variable = this.variable.ToNative() ,
			    type = this.Type.DangerousGetHandle() ,
			    name = allocator.AllocAnsiString(this.Name) ,
			    autoDefined = this.AutoDefined ,
			    typeConfidence = this.TypeConfidence
		    };
	    }

	    public override string ToString()
	    {
		    return this.Name;
	    }
    }
}