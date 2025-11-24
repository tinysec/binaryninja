using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct BNCustomTransform 
	{
		// BNTransformParameterInfo* (*getParameters)(void* ctxt, size_t* count);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate IntPtr GetParametersDelegate(
			IntPtr ctxt,
			IntPtr count
		);
		
		// void (*freeParameters)(BNTransformParameterInfo* params, size_t count);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate void FreeParametersDelegate(
			IntPtr parameters,
			ulong count
		);
		
		// bool (*decode)(void* ctxt, BNDataBuffer* input, BNDataBuffer* output, BNTransformParameter* params, size_t paramCount);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool DecodeDelegate(
			IntPtr ctxt,
			IntPtr input,
			IntPtr output,
			IntPtr parameters,
			ulong  paramCount
		);
		
		// bool (*encode)(void* ctxt, BNDataBuffer* input, BNDataBuffer* output, BNTransformParameter* params, size_t paramCount);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool EncodeDelegate(
			IntPtr ctxt,
			IntPtr input,
			IntPtr output,
			IntPtr parameters,
			ulong  paramCount
		);
		
		// bool (*decodeWithContext)(void* ctxt, BNTransformContext* context, BNTransformParameter* params, size_t paramCount);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool DecodeWithContextDelegate(
			IntPtr ctxt,
			IntPtr context,
			IntPtr parameters,
			ulong  paramCount
		);
		
		// bool (*canDecode)(void* ctxt, BNBinaryView* input);
		[UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
		internal unsafe delegate bool CanDecodeDelegate(
			IntPtr ctxt,
			IntPtr input
		);
		
		/// <summary>
		/// void* context
		/// </summary>
		internal IntPtr context;
		
		/// <summary>
		/// void** getParameters
		/// </summary>
		internal IntPtr getParameters;
		
		/// <summary>
		/// void** freeParameters
		/// </summary>
		internal IntPtr freeParameters;
		
		/// <summary>
		/// void** decode
		/// </summary>
		internal IntPtr decode;
		
		/// <summary>
		/// void** encode
		/// </summary>
		internal IntPtr encode;
		
		/// <summary>
		/// void** decodeWithContext
		/// </summary>
		internal IntPtr decodeWithContext;
		
		/// <summary>
		/// void** canDecode
		/// </summary>
		internal IntPtr canDecode;
	}

	public class CustomTransform : INativeWrapper<BNCustomTransform>
	{
		public CustomTransform()
		{

		}

		public Transform? RegisterTransformType(
			TransformType type,
			string name,
			string longname,
			string group
		)
		{
			return Transform.FromHandle(

				NativeMethods.BNRegisterTransformType(
					type,
					name,
					longname,
					group,
					this.ToNative()
				)
			);
		}
		
		public Transform? RegisterTransformTypeWithCapabilities(
			TransformType type,
			uint capabilities,
			string name,
			string longname,
			string group
		)
		{
			return Transform.FromHandle(

				NativeMethods.BNRegisterTransformTypeWithCapabilities(
					type,
					capabilities,
					name,
					longname,
					group,
					this.ToNative()
				)
			);
		}

		public BNCustomTransform ToNative()
		{
			return new BNCustomTransform()
			{
				context = IntPtr.Zero ,
				getParameters = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.GetParametersDelegate>(this.GetParametersThunk) ,
				freeParameters = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.FreeParametersDelegate>(this.FreeParametersThunk) ,
				decode = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.DecodeDelegate>(this.DecodeThunk) ,
				encode = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.EncodeDelegate>(this.EncodeThunk) ,
				decodeWithContext = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.DecodeWithContextDelegate>(this.DecodeWithContextThunk) ,
				canDecode = Marshal.GetFunctionPointerForDelegate<BNCustomTransform.CanDecodeDelegate>(this.CanDecodeThunk) ,
			};
		}
		
		
		// BNTransformParameterInfo* (*getParameters)(void* ctxt, size_t* count);
		private IntPtr GetParametersThunk(
			IntPtr ctxt ,
			IntPtr count
		)
		{
			TransformParameterInfo[] parameters = this.GetParameters();

			if (parameters.Length == 0)
			{
				return IntPtr.Zero;
			}

			BNTransformParameterInfo[] natives = TransformParameterInfo.UnsafeToNativeArray(
				parameters
			);
			
			return UnsafeUtils.AllocStructArray<BNTransformParameterInfo>(natives);
		}

		// void (*freeParameters)(BNTransformParameterInfo* params, size_t count);
		private void FreeParametersThunk(
			IntPtr parameters ,
			ulong parametersCount
		)
		{
			if (0 == parameters)
			{
				return;
			}
			
			if (0 == parametersCount)
			{
				return;
			}

			for (ulong i = 0; i < parametersCount; i++)
			{
				int offset = checked((int)(i * (ulong)Marshal.SizeOf<BNTransformParameterInfo>()));
					
				IntPtr addressOfElement = IntPtr.Add(parameters, offset);
					
				BNTransformParameterInfo? parameter = Marshal.PtrToStructure<BNTransformParameterInfo>(
					addressOfElement
				);

				if (null != parameter)
				{
					BNTransformParameterInfo info = parameter.Value;
					
					if (IntPtr.Zero != info.name)
					{
						Marshal.FreeHGlobal(info.name);
					}
					
					if (IntPtr.Zero != info.longName)
					{
						Marshal.FreeHGlobal(info.longName);
					}
				}
			}
			
			Marshal.FreeHGlobal(parameters);
		}

		// bool (*decode)(void* ctxt, BNDataBuffer* input, BNDataBuffer* output, BNTransformParameter* params, size_t paramCount);
		private bool DecodeThunk(
			IntPtr ctxt ,
			IntPtr input ,
			IntPtr output ,
			IntPtr rawParameters ,
			ulong paramCount
		)
		{
			TransformParameter[] parameters = UnsafeUtils.ReadStructArray<BNTransformParameter,TransformParameter>(
				rawParameters ,
				paramCount,
				TransformParameter.FromNative
			);
			
			return this.Decode(
				DataBuffer.MustBorrowHandle(input) ,
				DataBuffer.MustBorrowHandle(output) ,
				parameters
			);
		}

		// bool (*encode)(void* ctxt, BNDataBuffer* input, BNDataBuffer* output, BNTransformParameter* params, size_t paramCount);
		private bool EncodeThunk(
			IntPtr ctxt ,
			IntPtr input ,
			IntPtr output ,
			IntPtr rawParameters ,
			ulong paramCount
		)
		{
			TransformParameter[] parameters = UnsafeUtils.ReadStructArray<BNTransformParameter,TransformParameter>(
				rawParameters ,
				paramCount,
				TransformParameter.FromNative
			);
			
			return this.Encode(
				DataBuffer.MustBorrowHandle(input) ,
				DataBuffer.MustBorrowHandle(output) ,
				parameters
			);
		}

		// bool (*decodeWithContext)(void* ctxt, BNTransformContext* context, BNTransformParameter* params, size_t paramCount);
		private bool DecodeWithContextThunk(
			IntPtr ctxt ,
			IntPtr context ,
			IntPtr rawParameters ,
			ulong paramCount
		)
		{
			TransformParameter[] parameters = UnsafeUtils.ReadStructArray<BNTransformParameter,TransformParameter>(
				rawParameters ,
				paramCount,
				TransformParameter.FromNative
			);
			
			return this.DecodeWithContext(
				TransformContext.MustBorrowHandle(context),
				parameters
			);
		}

		// bool (*canDecode)(void* ctxt, BNBinaryView* input);
		private bool CanDecodeThunk(
			IntPtr ctxt ,
			IntPtr input
		)
		{
			return this.CanDecode(
				BinaryView.MustBorrowHandle(input)
			);
		}

		#region methods

		public virtual TransformParameterInfo[] GetParameters()
		{
			return Array.Empty<TransformParameterInfo>();
		}
		
		public virtual bool Decode(
			DataBuffer input ,
			DataBuffer output ,
			TransformParameter[] parameters
		)
		{
			return false;
		}

		public virtual bool Encode(
			DataBuffer input ,
			DataBuffer output ,
			TransformParameter[] parameters
		)
		{
			return false;
		}
		
		public virtual bool DecodeWithContext(TransformContext context , TransformParameter[] parameters)
		{
			return false;
		}
		
		public virtual bool CanDecode(BinaryView input)
		{
			return false;
		}

		#endregion methods
    }
}