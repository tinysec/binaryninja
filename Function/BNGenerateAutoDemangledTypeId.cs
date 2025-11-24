using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    public static partial class Core
    {
	    public static string GenerateAutoDemangledTypeId(QualifiedName name)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return UnsafeUtils.TakeAnsiString(

				    NativeMethods.BNGenerateAutoDemangledTypeId(
					    name.ToNativeEx(allocator)
				    )
			    );
		    }
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGenerateAutoDemangledTypeId(BNQualifiedName* name)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGenerateAutoDemangledTypeId"
	    )]
	    internal static extern IntPtr BNGenerateAutoDemangledTypeId(
			
		    // BNQualifiedName* name
		    in BNQualifiedName name  
	    );
    }
    
}