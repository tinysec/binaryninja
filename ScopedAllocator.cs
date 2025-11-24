using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BinaryNinja
{
	public class ScopedAllocator : IDisposable
	{
		private readonly List<IntPtr> m_pointers = new List<IntPtr>();

		private bool m_disposed = false;
		
		public void Dispose()
		{
			if (!m_disposed)
			{
				foreach (IntPtr pointer in m_pointers)
				{
					if (pointer != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(pointer);
					}
				}

				m_pointers.Clear();
				
				m_disposed = true;
			}
		}
		
		internal IntPtr AllocHGlobal(int size)
		{
			IntPtr pointer = Marshal.AllocHGlobal(size);
			
			m_pointers.Add(pointer);
		
			return pointer;
		}
		
		internal IntPtr AllocAnsiString(string text)
		{
			IntPtr pointer = Marshal.StringToHGlobalAnsi(text);
			
			m_pointers.Add(pointer);

			return pointer;
		}
		
		internal IntPtr AllocAnsiStringArray(string[] texts)
		{
			if (texts == null || texts.Length == 0)
			{
				return IntPtr.Zero;
			}

			IntPtr arrayPointer = this.AllocHGlobal(IntPtr.Size * texts.Length);
			
			for (int i = 0; i < texts.Length; i++)
			{
				IntPtr textPointer = this.AllocAnsiString(texts[i]);
				
				Marshal.WriteIntPtr(arrayPointer , i * IntPtr.Size , textPointer);
			}

			return arrayPointer;
		}

		internal IntPtr AllocInteger<T>(T value) where T : IConvertible
		{
			int elementSize = Marshal.SizeOf<T>();
			
			IntPtr pointer = this.AllocHGlobal(elementSize);
			
			if (1 == elementSize)
			{
				Marshal.WriteByte(pointer , Convert.ToByte((IConvertible)value));
			}
			else if (2 == elementSize)
			{
				Marshal.WriteInt16(pointer , Convert.ToInt16((IConvertible)value));
			}
			else if (4 == elementSize)
			{
				Marshal.WriteInt32(pointer , Convert.ToInt32((IConvertible)value));
			}
			else if (8 == elementSize)
			{
				Marshal.WriteInt64(pointer , Convert.ToInt64((IConvertible)value));
			}
			else
			{
				throw new Exception("Unsupported element type");
			}

			return pointer;
		}
		
		internal IntPtr AllocIntegerArray<T>(T[] items) where T : IConvertible
		{
			if (items == null || items.Length == 0)
			{
				return IntPtr.Zero;
			}
			
			int elementSize = Marshal.SizeOf<T>();

			IntPtr arrayPointer = this.AllocHGlobal(IntPtr.Size * items.Length);

			for (int i = 0; i < items.Length; i++)
			{
				IntPtr addressOfElement = IntPtr.Add(arrayPointer , i * elementSize);

				if (1 == elementSize)
				{
					Marshal.WriteByte(addressOfElement , Convert.ToByte((IConvertible)items[i]));
				}
				else if (2 == elementSize)
				{
					Marshal.WriteInt16(addressOfElement , Convert.ToInt16((IConvertible)items[i]));
				}
				else if (4 == elementSize)
				{
					Marshal.WriteInt32(addressOfElement , Convert.ToInt32((IConvertible)items[i]));
				}
				else if (8 == elementSize)
				{
					Marshal.WriteInt64(addressOfElement , Convert.ToInt64((IConvertible)items[i]));
				}
				else
				{
					throw new Exception("Unsupported element type");
				}
			}

			return arrayPointer;
		}
		
		internal IntPtr AllocStruct<T>(T structure) where T : struct
		{
			int size = Marshal.SizeOf<T>();
			
			IntPtr pointer = this.AllocHGlobal(size);
	
			Marshal.StructureToPtr(structure , pointer , false);

			return pointer;
		}

		internal IntPtr AllocStructArray<T>(T[] structures) where T : struct
		{
			if (structures == null || structures.Length == 0)
			{
				return IntPtr.Zero;
			}

			int structSize = Marshal.SizeOf<T>();
			
			int totalSize = structSize * structures.Length;
			
			IntPtr arrayPointer = this.AllocHGlobal(totalSize);

			for (int i = 0; i < structures.Length; i++)
			{
				IntPtr addressOfElement = IntPtr.Add(arrayPointer , i * structSize);
				
				Marshal.StructureToPtr(structures[i] , addressOfElement , false);
			}

			return arrayPointer;
		}
		
		internal IntPtr AllocHandleArray<T>(T[] handles) where T : SafeHandle
		{
			if (handles == null || handles.Length == 0)
			{
				return IntPtr.Zero;
			}
			
			int totalSize = IntPtr.Size * handles.Length;
			
			IntPtr arrayPointer = this.AllocHGlobal(totalSize);
	
			for (int i = 0; i < handles.Length; i++)
			{
				IntPtr addressOfElement = IntPtr.Add(arrayPointer , i * IntPtr.Size);
				
				Marshal.WriteIntPtr(addressOfElement , handles[i].DangerousGetHandle() );
			}

			return arrayPointer;
		}
		
		internal TNative[] ConvertToNativeArrayEx<TNative,TManaged>(TManaged[] sources)
			where TManaged : INativeWrapperEx<TNative>
		{
			if (sources == null || sources.Length == 0)
			{
				return Array.Empty<TNative>();
			}
				
			List<TNative> targets = new List<TNative>();

			for (int i = 0; i < sources.Length; i++)
			{
				targets.Add( sources[i].ToNativeEx(this));
			}
				
			return targets.ToArray();
		} 
	}
}
