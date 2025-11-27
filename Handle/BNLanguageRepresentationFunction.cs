using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class LanguageRepresentationFunction : AbstractSafeHandle
	{
	    internal LanguageRepresentationFunction(IntPtr handle , bool owner) 
		    : base(handle , owner)
	    {
	        
	    }
	    
	    internal static LanguageRepresentationFunction? NewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new LanguageRepresentationFunction(
			    NativeMethods.BNNewLanguageRepresentationFunctionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static LanguageRepresentationFunction MustNewFromHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new LanguageRepresentationFunction(
			    NativeMethods.BNNewLanguageRepresentationFunctionReference(handle) ,
			    true
		    );
	    }
	    
	    internal static LanguageRepresentationFunction? TakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new LanguageRepresentationFunction(handle, true);
	    }
	    
	    internal static LanguageRepresentationFunction MustTakeHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new LanguageRepresentationFunction(handle, true);
	    }
	    
	    internal static LanguageRepresentationFunction? BorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    return null;
		    }
		    
		    return new LanguageRepresentationFunction(handle, false);
	    }
	    
	    internal static LanguageRepresentationFunction MustBorrowHandle(IntPtr handle)
	    {
		    if (handle == IntPtr.Zero)
		    {
			    throw new ArgumentNullException(nameof(handle));
		    }
		    
		    return new LanguageRepresentationFunction(handle, false);
	    }
	    
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeLanguageRepresentationFunction(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }

	    public override string ToString()
	    {
		    return this.GetLinearDisassemblyText();
	    }

	    public Architecture Architecture
	    {
		    get
		    {
			    return Architecture.MustFromHandle(
				    NativeMethods.BNGetLanguageRepresentationArchitecture(this.handle)
			    );
		    }
	    }
	    
	    public Function OwnerFunction
	    {
		    get
		    {
			    return Function.MustTakeHandle(
				    NativeMethods.BNGetLanguageRepresentationOwnerFunction(this.handle)
			    );
		    }
	    }
	    
	    // forward
	    public ulong HighestAddress
	    {
		    get
		    {
			    return this.OwnerFunction.HighestAddress;
		    }
	    }
	    
	    public ulong LowestAddress
	    {
		    get
		    {
			    return this.OwnerFunction.LowestAddress;
		    }
	    }
	    
	    public Symbol Symbol
	    {
		    get
		    {
			    return this.OwnerFunction.Symbol;
		    }
	    }
	    
	    public string ShortName
	    {
		    get
		    {
			    return this.Symbol.ShortName;
		    }
	    }
	    
	    public string FullName
	    {
		    get
		    {
			    return this.Symbol.FullName;
		    }
	    }
	    
	    public string RawName
	    {
		    get
		    {
			    return this.Symbol.RawName;
		    }
	    }
	    
	    public HighLevelILFunction HighLevelIL
	    {
		    get
		    {
			    return HighLevelILFunction.MustTakeHandle(
				    NativeMethods.BNGetLanguageRepresentationILFunction(this.handle)
			    );
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelIL
	    {
		    get
		    {
			    return this.HighLevelIL.MediumLevelIL;
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelILSSAForm
	    {
		    get
		    {
			    return this.HighLevelIL.MediumLevelILSSAForm;
		    }
	    }
	    
	    public MediumLevelILFunction? MediumLevelILNonSSAForm
	    {
		    get
		    {
			    return this.HighLevelIL.MediumLevelILNonSSAForm;
		    }
	    }
	    
	    public LowLevelILFunction? LowLevelIL
	    {
		    get
		    {
			    return this.HighLevelIL.LowLevelIL;
		    }
	    }
	    
	    public LinearViewObject CreateLinearView( 
		    DisassemblySettings? settings = null,
		    string language = "Pseudo C"
	    ) 
	    {
		    if (null == settings)
		    {
			    settings = DisassemblySettings.DefaultLinear();
			    settings.SetOption(DisassemblyOption.WaitForIL , true);
		    }
		    
		    return LinearViewObject.MustTakeHandle(
			    NativeMethods.BNCreateLinearViewSingleFunctionLanguageRepresentation(
				    this.OwnerFunction.DangerousGetHandle() ,
				    null == settings ? IntPtr.Zero : settings.DangerousGetHandle() ,
				    language
			    )
		    );
	    }
	    
	    public LinearDisassemblyLine[] GetLinearDisassemblyLines(
		    DisassemblySettings? settings = null,
		    string language = "Pseudo C"
		)
	    {
		    LinearViewObject linear = this.CreateLinearView(settings);
		    
		    LinearViewCursor cursor = linear.CreateCursor();
		    
		    List<LinearDisassemblyLine> targets = new List<LinearDisassemblyLine>();
		    
		    cursor.SeekToAddress(this.LowestAddress);
		    foreach (LinearDisassemblyLine line in cursor.PreviousLines)
		    {
			    if (!targets.Contains(line))
			    {
				    targets.Add(line);
			    }
		    }
		    
		    cursor.SeekToAddress(this.HighestAddress);
		    foreach (LinearDisassemblyLine line in cursor.NextLines)
		    {
			    if (!targets.Contains(line))
			    {
				    targets.Add(line);
			    }
		    }

		    return targets.ToArray();
	    }
	    
	    public IEnumerable<LinearDisassemblyLine> LinearDisassemblyLines
	    {
		    get
		    {
			    return this.GetLinearDisassemblyLines();
		    }
	    }
	    
	    public string GetLinearDisassemblyText(
		    DisassemblySettings? settings = null,
		    string language = "Pseudo C"
		)
	    {
		    StringBuilder builder = new StringBuilder();

		    foreach (LinearDisassemblyLine line in this.GetLinearDisassemblyLines(
			             settings ,
			             language
			             )
		    )
		    {
			    builder.AppendLine(line.ToString());
		    }

		    return builder.ToString();
	    }

	    public string LinearDisassemblyText
	    {
		    get
		    {
			    return this.GetLinearDisassemblyText();
		    }
	    }
	}
}