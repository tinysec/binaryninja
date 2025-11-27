using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace BinaryNinja
{
	public sealed class Settings : AbstractSafeHandle
	{
		public Settings(string schemaId = "default") 
			: this(NativeMethods.BNCreateSettings(schemaId)  , true)
		{
			
		}
		
		internal Settings(IntPtr handle , bool owner) 
			: base(handle , owner)
		{
			
		}

		internal static Settings? NewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Settings(
				NativeMethods.BNNewSettingsReference(handle) ,
				true
			);
		}
	    
		internal static Settings MustNewFromHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Settings(
				NativeMethods.BNNewSettingsReference(handle) ,
				true
			);
		}
	    
		internal static Settings? TakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Settings(handle, true);
		}
	    
		internal static Settings MustTakeHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Settings(handle, true);
		}
	    
		internal static Settings? BorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
		    
			return new Settings(handle, false);
		}
	    
		internal static Settings MustBorrowHandle(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentNullException(nameof(handle));
			}
		    
			return new Settings(handle, false);
		}
		
	    protected override bool ReleaseHandle()
	    {
	        if ( !this.IsInvalid )
	        {
	            NativeMethods.BNFreeSettings(this.handle);
	            this.SetHandleAsInvalid();
	        }
	        
	        return true;
	    }
	  
	    public string ResourceId
	    {
		    set
		    {
			    NativeMethods.BNSettingsSetResourceId(this.handle, value);
		    }
	    }

	    public bool RegisterGroup(string group , string title)
	    {
		    return NativeMethods.BNSettingsRegisterGroup(this.handle , group ,title);
	    }
	    
	    public bool RegisterSetting(string key , string properties)
	    {
		    return NativeMethods.BNSettingsRegisterSetting(this.handle , key ,properties);
	    }
	    
	    public bool Contains(string key)
	    {
		    return NativeMethods.BNSettingsContains(this.handle, key);
	    }
	    
	    public bool IsEmpty(BinaryView view , Function function, SettingsScope scope)
	    {
		    return NativeMethods.BNSettingsIsEmpty(
			    this.handle, 
			    view.DangerousGetHandle(),
			    function.DangerousGetHandle(),
			    scope
			);
	    }

	    public string[] Keys
	    {
		    get
		    {
			    IntPtr arrayPointer =  NativeMethods.BNSettingsKeysList(this.handle , out ulong  arrayLength);

			    return UnsafeUtils.TakeAnsiStringArray(
				    arrayPointer ,
				    arrayLength,
				    NativeMethods.BNFreeStringList
			    );
		    }
	    }

	    public string QueryPropertyString(string key , string property)
	    {
		    return UnsafeUtils.TakeAnsiString(
				    NativeMethods.BNSettingsQueryPropertyString(this.handle, key , property)
			);
	    }
	    
	    public string[] QueryPropertyStringList(string key , string property)
	    {
		    IntPtr arrayPointer = NativeMethods.BNSettingsQueryPropertyStringList(
			    this.handle ,
			    key ,
			    property ,
			    out ulong arrayLength
		    );
			    
		    return UnsafeUtils.TakeAnsiStringArray(
			    arrayPointer,
			    arrayLength,
			    NativeMethods.BNFreeStringList
		    );
	    }
	    
	    public bool UpdateProperty(string key , string property)
	    {
		    return NativeMethods.BNSettingsUpdateProperty(this.handle , key , property);
	    }
	    
	    public bool DeserializeSchema(string schema , SettingsScope scope , bool merge)
	    {
		    return NativeMethods.BNSettingsDeserializeSchema(this.handle , schema , scope , merge);
	    }
	    
	    public string SerializeSchema()
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNSettingsSerializeSchema(this.handle)
		    );
	    }
	    
	    public bool DeserializeSettings(
		    string contents , 
		    BinaryView view , 
		    Function function ,
		    SettingsScope scope)
	    {
		    return NativeMethods.BNDeserializeSettings(
			    this.handle ,
			    contents ,
			    view.DangerousGetHandle() ,
			    function.DangerousGetHandle() ,
			    scope
		    );
	    }
	    
	    public string SerializeSettings(
		    BinaryView view , 
		    Function function ,
		    SettingsScope scope)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNSerializeSettings(
			    this.handle ,
			    view.DangerousGetHandle() ,
			    function.DangerousGetHandle() ,
			    scope
				)
			);
	    }
	    
	    public bool Reset(
		    string key,
		    BinaryView view , 
		    Function function ,
		    SettingsScope scope)
	    {
		    return NativeMethods.BNSettingsReset(
				    this.handle ,
				    key,
				    view.DangerousGetHandle() ,
				    function.DangerousGetHandle() ,
				    scope
		    );
	    }
	    
	    public bool ResetAll(
		    BinaryView view , 
		    Function function ,
		    SettingsScope scope,
		    bool schemaOnly)
	    {
		    return NativeMethods.BNSettingsResetAll(
			    this.handle ,
			    view.DangerousGetHandle() ,
			    function.DangerousGetHandle() ,
			    scope,
			    schemaOnly
		    );
	    }
	    
	    public bool GetBool(
		    string key,
		    BinaryView? view, 
		    Function? function,
			out SettingsScope scope 
		)
	    {
		    return NativeMethods.BNSettingsGetBool(
			    this.handle, 
			    key , 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    out scope
			);
	    }
	    
	    public double GetDouble(
		    string key,
		    BinaryView? view, 
		    Function? function,
		    out SettingsScope scope 
	    )
	    {
		    return NativeMethods.BNSettingsGetDouble(
			    this.handle, 
			    key , 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    out scope
		    );
	    }
	    
	    public T GetInteger<T>( 
		    string key,
		    BinaryView? view, 
		    Function? function,
		    out SettingsScope scope 
		) where T : unmanaged
	    {
		    ulong slug = NativeMethods.BNSettingsGetUInt64(
			    this.handle, 
			    key , 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    out scope
		    );
		    
		    if (typeof(T).UnderlyingSystemType == typeof(sbyte))
		    {
			    return UnsafeUtils.ForceConvert<sbyte, T>( (sbyte)slug);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(byte))
		    {
			    return UnsafeUtils.ForceConvert<byte, T>( (byte)slug );
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(short))
		    {
			    return UnsafeUtils.ForceConvert<short, T>( (short)slug);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(ushort))
		    {
			    return UnsafeUtils.ForceConvert<ushort, T>( (ushort)slug); 
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(int))
		    {
			    return UnsafeUtils.ForceConvert<int , T>( (int)slug);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(uint))
		    {
			    return UnsafeUtils.ForceConvert<uint , T>( (uint)slug);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(long))
		    {
			    return UnsafeUtils.ForceConvert<long , T>((long)slug);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(ulong))
		    {
			    return UnsafeUtils.ForceConvert<ulong ,T>((ulong)slug);
		    }
				
		    throw new NotSupportedException($"not supported type: {typeof(T).UnderlyingSystemType}");
	    }
	    
	    public string GetString(
		    string key,
		    BinaryView? view, 
		    Function? function,
		    out SettingsScope scope 
		)
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNSettingsGetString(
				    this.handle, 
				    key , 
				    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
				    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
				    out scope
				)
		    );
	    }
	    
	    public string[] GetStringList(
		    string key,
		    BinaryView? view, 
		    Function? function,
		    out SettingsScope scope 
		)
	    {
		    IntPtr arrayPointer = NativeMethods.BNSettingsGetStringList(
			    this.handle, 
			    key , 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    out scope,
			    out ulong arrayLength
		    );
			    
		    return UnsafeUtils.TakeAnsiStringArray(
			    arrayPointer,
			    arrayLength,
			    NativeMethods.BNFreeStringList
		    );
	    }
	    
	    public string GetJson(
		    string key,
		    BinaryView? view, 
		    Function? function,
		    out SettingsScope scope
	    )
	    {
		    return UnsafeUtils.TakeAnsiString(
			    NativeMethods.BNSettingsGetJson(
				    this.handle, 
				    key , 
				    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
				    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
				    out scope
			    )
		    );
	    }
	    
	    
	    public bool SetBool(
		    string key,
		    bool value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    )
	    {
		    return NativeMethods.BNSettingsSetBool(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    value
		    );
	    }
	    
	    public bool SetDouble(
		    string key,
		    double value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    )
	    {
		    return NativeMethods.BNSettingsSetDouble(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    value
		    );
	    }
	    
	    public bool SetInteger<T>( 
		    string key,
		    T value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    ) where T : unmanaged
	    {
		    ulong slug = 0;
		    
		    if (typeof(T).UnderlyingSystemType == typeof(sbyte))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(byte))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(short))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(ushort))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(int))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(uint))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(long))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else if (typeof(T).UnderlyingSystemType == typeof(ulong))
		    {
			    slug  = (ulong)UnsafeUtils.ForceConvert<T,sbyte>( value);
		    }
		    else
		    {
			    throw new NotSupportedException($"not supported type: {typeof(T).UnderlyingSystemType}");
		    }
			
		    return NativeMethods.BNSettingsSetUInt64(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    slug
		    );
	    }
	    
	    public bool SetString(
		    string key,
		    string value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    )
	    {
		    return NativeMethods.BNSettingsSetString(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    value
		    );
	    }
	    
	    public bool SetStringList(
		    string key,
		    string[] value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    )
	    {
		    return NativeMethods.BNSettingsSetStringList(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    value,
			    (ulong)value.Length
		    );
	    }
	    
	    public bool SetJson(
		    string key,
		    string value,
		    BinaryView? view, 
		    Function? function,
		    SettingsScope scope = SettingsScope.SettingsAutoScope
	    )
	    {
		    return NativeMethods.BNSettingsSetJson(
			    this.handle, 
			    null == view ? IntPtr.Zero : view.DangerousGetHandle() ,
			    null == function ? IntPtr.Zero : function.DangerousGetHandle(),
			    scope ,
			    key,
			    value
		    );
	    }
	}
}