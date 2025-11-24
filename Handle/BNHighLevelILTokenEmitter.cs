using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class HighLevelILTokenEmitter : AbstractSafeHandle<HighLevelILTokenEmitter>
	{
	    internal HighLevelILTokenEmitter(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static HighLevelILTokenEmitter? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILTokenEmitter(
			    NativeMethods.BNNewHighLevelILTokenEmitterReference(handle) ,
			    true
		    );
	    }
	    
	    internal static HighLevelILTokenEmitter MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILTokenEmitter(
			    NativeMethods.BNNewHighLevelILTokenEmitterReference(handle) ,
			    true
		    );
	    }
	    
	    internal static HighLevelILTokenEmitter? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILTokenEmitter(handle, true);
	    }
	    
	    internal static HighLevelILTokenEmitter MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILTokenEmitter(handle, true);
	    }
	    
	    internal static HighLevelILTokenEmitter? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new HighLevelILTokenEmitter(handle, false);
	    }
	    
	    internal static HighLevelILTokenEmitter MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new HighLevelILTokenEmitter(handle, false);
	    }

	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeHighLevelILTokenEmitter(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public void InitLine()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterInitLine(this.handle);
	    }
	    
	    public void NewLine()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterNewLine(this.handle);
	    }
	    
	    public void IncreaseIndent()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterIncreaseIndent(this.handle);
	    }
	    
	    public void DecreaseIndent()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterDecreaseIndent(this.handle);
	    }
	    
	    public void ScopeSeparator()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterScopeSeparator(this.handle);
	    }
	    
	    public void BeginScope(ScopeType type)
	    {
		    NativeMethods.BNHighLevelILTokenEmitterBeginScope(this.handle , type);
	    }
	    
	    public void EndScope(ScopeType type)
	    {
		    NativeMethods.BNHighLevelILTokenEmitterEndScope(this.handle , type);
	    }
	    
	    public void ScopeContinuation(bool forceSameLine)
	    {
		    NativeMethods.BNHighLevelILTokenEmitterScopeContinuation(this.handle , forceSameLine);
	    }
	    
	    public void FinalizeScope()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterFinalizeScope(this.handle);
	    }
	    
	    public void NoIndentForThisLine()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterNoIndentForThisLine(this.handle);
	    }

	    public void PrependCollapseBlankIndicator()
	    {
		    NativeMethods.BNHighLevelILTokenPrependCollapseBlankIndicator(this.handle);
	    }
	    
	    public void PrependCollapseIndicator(InstructionTextTokenContext context , ulong hash )
	    {
		    NativeMethods.BNHighLevelILTokenPrependCollapseIndicator(
			    this.handle,
			    context,
			    hash
			);
	    }
	    
	    public bool HasCollapsableRegions
	    {
		    get
		    {
			    return NativeMethods.BNHighLevelILTokenEmitterHasCollapsableRegions(this.handle);
		    }

		    set
		    {
			    NativeMethods.BNHighLevelILTokenEmitterSetHasCollapsableRegions(this.handle, value);
		    }
	    }
	    
	    public void BeginForceZeroConfidence()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterBeginForceZeroConfidence(
			    this.handle
		    );
	    }
	    
	    public void EndForceZeroConfidence()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterEndForceZeroConfidence(
			    this.handle
		    );
	    }
	    
	    public void SetCurrentExpr(TokenEmitterExpression expr)
	    {
		    NativeMethods.BNHighLevelILTokenEmitterSetCurrentExpr(
			    this.handle ,
			    expr.ToNative()
		    );
	    }
	    
	    public void RestoreCurrentExpr(TokenEmitterExpression expr)
	    {
		    NativeMethods.BNHighLevelILTokenEmitterRestoreCurrentExpr(
			    this.handle,
			    expr.ToNative()
		    );
	    }
	    
	    public void FinalizeEmit()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterFinalize(
			    this.handle
		    );
	    }
	    
	    public void Append(InstructionTextToken token)
	    {
		    using (ScopedAllocator allocator = new ScopedAllocator())
		    {
			    NativeMethods.BNHighLevelILTokenEmitterAppend(
				    this.handle,
				    token.ToNativeEx(allocator)
			    );
		    }
	    }
	    
	    public void AppendOpenParen()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendOpenParen(
			    this.handle
		    );
	    }
	    
	    public void AppendCloseParen()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendCloseParen(
			    this.handle
		    );
	    }
	    
	    public void AppendOpenBracket()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendOpenBracket(
			    this.handle
		    );
	    }
	    
	    public void AppendCloseBracket()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendCloseBracket(
			    this.handle
		    );
	    }
	    
	    public void AppendOpenBrace()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendOpenBrace(
			    this.handle
		    );
	    }
	    
	    public void AppendCloseBrace()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendCloseBrace(
			    this.handle
		    );
	    }
	    
	    public void AppendSemicolon()
	    {
		    NativeMethods.BNHighLevelILTokenEmitterAppendSemicolon(
			    this.handle
		    );
	    }
	    
	    public BraceRequirement BraceRequirement
	    {
		    get
		    {
			    return NativeMethods.BNHighLevelILTokenEmitterGetBraceRequirement(
				    this.handle
			    );
		    }
	    }
	}
}