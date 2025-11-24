using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public class TypeBuilder : AbstractSafeHandle<TypeBuilder>
	{
		internal TypeBuilder(IntPtr handle , bool owner) 
			: base(handle , owner)
		{
			
		}

		internal static TypeBuilder? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new TypeBuilder(handle, true);
		}
	    
		internal static TypeBuilder MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new TypeBuilder(handle, true);
		}
	    
		internal static TypeBuilder? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new TypeBuilder(handle, false);
		}
	    
		internal static TypeBuilder MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new TypeBuilder(handle, false);
		}
		
		protected override bool ReleaseHandle()
		{
			if (!this.IsInvalid)
			{
				NativeMethods.BNFreeTypeBuilder(this.handle);
				this.SetHandleAsInvalid();
			}

			return true;
		}

		public ulong Width
		{
			get
			{
				return NativeMethods.BNGetTypeBuilderWidth(this.handle);
			}

			set
			{
				NativeMethods.BNTypeBuilderSetWidth(this.handle , value);
			}
		}

		public BoolWithConfidence Const
		{
			get
			{
				return BoolWithConfidence.FromNative(NativeMethods.BNIsTypeBuilderConst(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetConst(this.handle , value.ToNative());
			}
		}

		public BoolWithConfidence Volatile
		{
			get
			{
				return BoolWithConfidence.FromNative( NativeMethods.BNIsTypeBuilderVolatile(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetVolatile(this.handle , value.ToNative());
			}
		}

		public ulong Alignment
		{
			get
			{
				return NativeMethods.BNGetTypeBuilderAlignment(this.handle);
			}

			set
			{
				NativeMethods.BNTypeBuilderSetAlignment(this.handle , value);
			}
		}

		public string AlternateName
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(NativeMethods.BNGetTypeBuilderAlternateName(this.handle));
			}

			set
			{
				NativeMethods.BNTypeBuilderSetAlternateName(this.handle , value);
			}
		}

		public bool SystemCall
		{
			get
			{
				return NativeMethods.BNTypeBuilderIsSystemCall(this.handle);
			}
		}

		public uint SystemCallNumber
		{
			get
			{
				return NativeMethods.BNTypeBuilderGetSystemCallNumber(this.handle);
			}

			set
			{
				NativeMethods.BNTypeBuilderSetSystemCallNumber(this.handle , true , value);
			}
		}

		public void ClearSystemCall()
		{
			NativeMethods.BNTypeBuilderSetSystemCallNumber(this.handle , false , 0);
		}

		public TypeClass TypeClass
		{
			get
			{
				return NativeMethods.BNGetTypeBuilderClass(this.handle);
			}
		}

		public BoolWithConfidence Signed
		{
			get
			{
				return BoolWithConfidence.FromNative( NativeMethods.BNIsTypeBuilderSigned(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetSigned(this.handle , value.ToNative());
			}
		}
	}

	public sealed class VoidTypeBuilder : TypeBuilder
	{
		public VoidTypeBuilder() 
			: base(NativeMethods.BNCreateVoidTypeBuilder() , true)
		{
			
		}
		
		public VoidType Build()
		{
			return new VoidType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class BoolTypeBuilder : TypeBuilder
	{
		public BoolTypeBuilder() 
			: base(NativeMethods.BNCreateBoolTypeBuilder() , true)
		{
			
		}

		public BoolType Build()
		{
			return new BoolType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class IntegerTypeBuilder : TypeBuilder
	{
		public IntegerTypeBuilder(
			ulong width , 
			BoolWithConfidence? sign = null, 
			string altName = ""
		) : base(
			IntegerTypeBuilder.create(
				width ,
				null == sign ? new BoolWithConfidence() : sign ,
				altName 
				) , true)
		{
			
		}
	
		internal static IntPtr create(
			ulong width , 
			BoolWithConfidence sign,
			string altName = ""
		)
		{
			
			return NativeMethods.BNCreateIntegerTypeBuilder(
				width , 
				sign.ToNative() ,
				altName
			);
		}
		
		public IntegerType Build()
		{
			return new IntegerType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class FloatTypeBuilder : TypeBuilder
	{
		public FloatTypeBuilder(ulong width , string altName = "") 
			: base(NativeMethods.BNCreateFloatTypeBuilder(width , altName ) , true)
		{
			
		}

		public FloatType Build()
		{
			return new FloatType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class CharTypeBuilder : TypeBuilder
	{
		public CharTypeBuilder(ulong width ,  string altName) 
			: base(
				IntegerTypeBuilder.create(
					width , 
					new BoolWithConfidence(true, Core.MaxConfidence) ,
					altName 
				) ,
				true
		)
		{
			
		}
		
		public CharType Build()
		{
			return new CharType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class WideCharTypeBuilder : TypeBuilder
	{
		public WideCharTypeBuilder(ulong width , string altName = "") 
			: base(NativeMethods.BNCreateWideCharTypeBuilder(width , altName ) , true)
		{
			
		}

		public WideCharType Build()
		{
			return new WideCharType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
	}
	
	public sealed class PointerTypeBuilder : TypeBuilder
	{
		public PointerTypeBuilder(
			ulong width ,
			TypeWithConfidence kind ,
			BoolWithConfidence? cnst = null ,
			BoolWithConfidence? vltl = null, // volatile
			ReferenceType refType = ReferenceType.PointerReferenceType
		) 
			: base(
				PointerTypeBuilder.create(
					width , 
					kind , 
					cnst ?? new BoolWithConfidence() , 
					vltl?? new BoolWithConfidence() , 
					refType
				) , true)
		{
			
		}

		
		private static IntPtr create(
			ulong width ,
			TypeWithConfidence kind,
			BoolWithConfidence cnst ,
			BoolWithConfidence vltl, // volatile
			ReferenceType refType 
		)
		{
			return NativeMethods.BNCreatePointerTypeBuilderOfWidth(
				width , 
				kind.ToNative() , 
				cnst.ToNative() ,  
				vltl.ToNative() ,  
				refType
			);
		}
		
		public PointerType Build()
		{
			return new PointerType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}

		public ulong Offset
		{
			get
			{
				return NativeMethods.BNGetTypeBuilderOffset(this.handle);
			}

			set
			{
				NativeMethods.BNSetTypeBuilderOffset(this.handle, value);
			}
		}
		
		public PointerSuffix[] PointerSuffix
		{
			get
			{
				ulong arrayLength = 0;
				
				IntPtr arrayPointer = NativeMethods.BNGetTypeBuilderPointerSuffix(this.handle , out arrayLength);

				return UnsafeUtils.TakeNumberArrayEx<PointerSuffix>(
					arrayPointer ,
					arrayLength ,
					NativeMethods.BNFreePointerSuffixList
				);
			}

			set
			{
				NativeMethods.BNSetTypeBuilderPointerSuffix(
					this.handle, 
					value,
					(ulong)value.Length
				);
			}
		}
		
		public string PointerSuffixString
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(NativeMethods.BNGetTypeBuilderPointerSuffixString(this.handle));
			}
		}
		
		public void AddPointerSuffix(PointerSuffix suffix)
		{
			NativeMethods.BNAddTypeBuilderPointerSuffix(this.handle, suffix);
		}

		public InstructionTextToken[] GetPointerSuffixTokens(byte baseConfidence)
		{
			ulong arrayLength = 0;
			
			IntPtr arrayPointer = NativeMethods.BNGetTypeBuilderPointerSuffixTokens(
				this.handle ,
				baseConfidence , 
				out arrayLength
			);

			return UnsafeUtils.TakeStructArrayEx<BNInstructionTextToken , InstructionTextToken>(
				arrayPointer,
				arrayLength,
				InstructionTextToken.FromNative,
				NativeMethods.BNFreeInstructionText
			);
		}

		public void SetPointerBase(PointerBaseType baseType , long baseOffset)
		{
			NativeMethods.BNSetTypeBuilderPointerBase(this.handle , baseType , baseOffset);
		}
		
		public PointerBaseType PointerBaseType
		{
			get
			{
				return NativeMethods.BNTypeBuilderGetPointerBaseType(this.handle);
			}
		}

		public long PointerBaseOffset
		{
			get
			{
				return NativeMethods.BNTypeBuilderGetPointerBaseOffset(this.handle);
			}

			set
			{
				NativeMethods.BNSetTypeBuilderPointerBase(this.handle, this.PointerBaseType, value);
			}
		}
		
	}

	public sealed class ArrayTypeBuilder : TypeBuilder
	{
		public ArrayTypeBuilder(
			TypeWithConfidence elementType ,
			ulong elementCount
		) : base(ArrayTypeBuilder.create(elementType , elementCount) , true)
		{

		}

		private static IntPtr create(
			TypeWithConfidence elementType ,
			ulong elementCount
		)
		{
			return NativeMethods.BNCreateArrayTypeBuilder(
				elementType.ToNative() ,
				elementCount
			);
		}
		
		public ArrayType Build()
		{
			return new ArrayType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
		
		public ulong ElementCount
		{
			get
			{
				return NativeMethods.BNGetTypeBuilderElementCount(this.handle);
			}

		}

		public TypeWithConfidence ElementType
		{
			get
			{
				return TypeWithConfidence.FromNative( NativeMethods.BNGetTypeBuilderChildType(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetChildType(this.handle , value.ToNative());
			}
		}

	}

	public sealed class FunctionTypeBuilder : TypeBuilder
	{
		public FunctionTypeBuilder(
			TypeWithConfidence? returnType ,
			CallingConventionWithConfidence? callingConvention ,
			FunctionParameter[]? parameters ,
			BoolWithConfidence? varArg ,
			BoolWithConfidence? canReturn ,
			OffsetWithConfidence? stackAdjust ,
			uint[]? regStackAdjustRegs = null,
			OffsetWithConfidence[]? regStackAdjustValues = null  ,
			RegisterSetWithConfidence? returnRegs = null ,
			NameType ft  = NameType.NoNameType,
			BoolWithConfidence? pure = null
		) : base(
			FunctionTypeBuilder.create(
				returnType ?? new TypeWithConfidence(new VoidType() , 0),
				callingConvention ?? new CallingConventionWithConfidence(callingConvention?.Convention , 0) ,
				parameters ?? Array.Empty<FunctionParameter>() ,
				varArg ?? new BoolWithConfidence() ,
				canReturn  ?? new BoolWithConfidence(),
				stackAdjust ?? new OffsetWithConfidence(),
				regStackAdjustRegs ?? Array.Empty<uint>() ,
				regStackAdjustValues ?? Array.Empty<OffsetWithConfidence>() ,
				returnRegs ?? new RegisterSetWithConfidence() ,
				ft ,
				pure ?? new BoolWithConfidence()
			) , true
		)
		{

		}
		
		private static IntPtr create(
			TypeWithConfidence returnType ,
			CallingConventionWithConfidence callingConvention ,
			FunctionParameter[] parameters ,
			BoolWithConfidence varArg ,
			BoolWithConfidence canReturn ,
			OffsetWithConfidence stackAdjust ,
			uint[] regStackAdjustRegs ,
			OffsetWithConfidence[] regStackAdjustValues ,
			RegisterSetWithConfidence returnRegs ,
			NameType ft ,
			BoolWithConfidence pure
		)
		{
			using (ScopedAllocator allocator = new ScopedAllocator())
			{
				return NativeMethods.BNCreateFunctionTypeBuilder(
					returnType.ToNative() ,
					callingConvention.ToNative() ,
					allocator.ConvertToNativeArrayEx<BNFunctionParameter,FunctionParameter>(
						parameters
					),
					(ulong)parameters.Length ,
					varArg.ToNative() ,
					canReturn.ToNative() ,
					stackAdjust.ToNative() ,
					regStackAdjustRegs ,
					UnsafeUtils.ConvertToNativeArray<BNOffsetWithConfidence,OffsetWithConfidence>(
						regStackAdjustValues
						),
					(ulong)regStackAdjustValues.Length ,
					returnRegs.ToNativeEx(allocator) ,
					ft ,
					pure.ToNative()
				);
			}
		}
		
		public FunctionType Build()
		{
			return new FunctionType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}

		public OffsetWithConfidence StackAdjustment
		{
			get
			{
				return OffsetWithConfidence.FromNative( NativeMethods.BNGetTypeBuilderStackAdjustment(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetStackAdjustment(this.handle , value.ToNative() );
			}
		}

		public TypeWithConfidence ReturnType
		{
			get
			{
				return TypeWithConfidence.FromNative( NativeMethods.BNGetTypeBuilderChildType(this.handle) );
			}

			set
			{
				NativeMethods.BNTypeBuilderSetChildType(this.handle, value.ToNative() );
			}
		}
		
		public CallingConventionWithConfidence CallingConvention
		{
			get
			{
				return CallingConventionWithConfidence.FromNative(NativeMethods.BNGetTypeBuilderCallingConvention(this.handle));
			}

			set
			{
				NativeMethods.BNTypeBuilderSetCallingConvention(this.handle, value.ToNative() );
			}
		}

		public FunctionParameter[] Parameters
		{
			get
			{
				ulong arrayLength = 0;
				
				IntPtr arrayPointer = NativeMethods.BNGetTypeBuilderParameters(this.handle , out arrayLength);
				
				return UnsafeUtils.TakeStructArrayEx<BNFunctionParameter , FunctionParameter>(
					arrayPointer,
					arrayLength,
					FunctionParameter.FromNative,
					NativeMethods.BNFreeTypeParameterList
				);
			}

			set
			{
				using (ScopedAllocator allocator = new ScopedAllocator())
				{
					NativeMethods.BNSetFunctionTypeBuilderParameters(
						this.handle ,
						allocator.ConvertToNativeArrayEx<BNFunctionParameter,FunctionParameter>(value),
						(ulong)value.Length
					);
				}
			}
		}

		public BoolWithConfidence HasVariableArguments
		{
			get
			{
				return BoolWithConfidence.FromNative(NativeMethods.BNTypeBuilderHasVariableArguments(this.handle));
			}
		}
		
		public BoolWithConfidence CanReturn
		{
			get
			{
				return BoolWithConfidence.FromNative(NativeMethods.BNFunctionTypeBuilderCanReturn(this.handle));
			}

			set
			{
				NativeMethods.BNSetFunctionTypeBuilderCanReturn(this.handle, value.ToNative());
			}
		}
		
		public BoolWithConfidence Pure
		{
			get
			{
				return BoolWithConfidence.FromNative(NativeMethods.BNIsTypeBuilderPure(this.handle));
			}

			set
			{
				NativeMethods.BNSetTypeBuilderPure(this.handle, value.ToNative());
			}
		}
	}

	public sealed class NamedTypeReferenceTypeBuilder : TypeBuilder
	{
		public NamedTypeReferenceTypeBuilder(
			NamedTypeReference namedType ,
			ulong width ,
			ulong align ,
			BoolWithConfidence cnst ,
			BoolWithConfidence vltl
		)
			: base(
				NamedTypeReferenceTypeBuilder.create(
					namedType ,
					width ,
					align ,
					cnst ,
					vltl
				) ,
				true
			)
		{

		}
		
		private static IntPtr create(
			NamedTypeReference namedType ,
			ulong width ,
			ulong align ,
			BoolWithConfidence cnst ,
			BoolWithConfidence vltl
		)
		{
			return NativeMethods.BNCreateNamedTypeReferenceBuilder(
				namedType.DangerousGetHandle() ,
				width ,
				align ,
				cnst.ToNative() ,
				vltl.ToNative()
			);
		}
		
		public NamedTypeReferenceType Build()
		{
			return new NamedTypeReferenceType( NativeMethods.BNFinalizeTypeBuilder(this.handle) , true);
		}
		
		public QualifiedName Name
		{
			get
			{
				return QualifiedName.FromNative(NativeMethods.BNGetTypeReferenceBuilderName(this.handle));
			}
		}
		
		public NamedTypeReferenceClass NamedTypeReferenceClass
		{
			get
			{
				return NativeMethods.BNGetTypeReferenceBuilderClass(this.handle);
			}
		}
		
		public string TypeReferenceId
		{
			get
			{
				return UnsafeUtils.TakeAnsiString(NativeMethods.BNGetTypeReferenceBuilderId(this.handle));
			}
		}

	}

	

}