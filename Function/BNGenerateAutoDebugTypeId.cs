using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
    internal static partial class NativeMethods
    {
	    public static string GenerateAutoDebugTypeId(QualifiedName name)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    return UnsafeUtils.TakeAnsiString(

				    BinaryNinja.NativeMethods.BNGenerateAutoDebugTypeId(
					    name.ToNativeEx(allocator)
				    )
			    );
		    }
	    }
	}
    
    internal static partial class NativeMethods
    {
	    /// <summary>
	    /// char* BNGenerateAutoDebugTypeId(BNQualifiedName* name)
	    /// </summary>
	    [DllImport(
		    "binaryninjacore", 
		    CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl,
		    EntryPoint = "BNGenerateAutoDebugTypeId"
	    )]
	    internal static extern IntPtr BNGenerateAutoDebugTypeId(
			
		    // BNQualifiedName* name
		    in BNQualifiedName name  
	    );
    }
}