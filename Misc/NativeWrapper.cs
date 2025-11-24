using System;
using System.Collections.Generic;

namespace BinaryNinja
{
	internal interface INativeWrapper<T>
	{
		internal T ToNative();
	}
	
	internal interface INativeWrapperEx<T>
	{
		internal T ToNativeEx(ScopedAllocator allocator);
	}
}
