using System;

namespace BinaryNinja
{
	public abstract class AbstractBinaryView : CustomBinaryView
	{
		protected BinaryView m_backend;
		
		internal AbstractBinaryView(BinaryView backend)
		{
			this.m_backend = backend;
		}
		
	    public override bool Init()
	    {
		    return true;
	    }
	    
	    public override void FreeObject()
	    {
		    
	    }
	    
	    public override void ExternalRefTaken()
	    {
		    
	    }
	    
	    public override void ExternalRefReleased()
	    {
		   
	    }
	    
	    public override byte[] Read(ulong offset , ulong length)
	    {
		    return this.m_backend.ReadData(offset, length);
	    }
	    
	    public override int Write(ulong offset , byte[] data)
	    {
		    return (int)this.m_backend.WriteData(offset , data);
	    }
	    
	    public override int Insert(ulong offset , byte[] data)
	    {
		    return (int)this.m_backend.InsertData(offset , data);
	    }
	    
	    public override ulong Remove(ulong offset , ulong length)
	    {
		    return this.m_backend.RemoveData(offset,length);
	    }
	    
	    public override ModificationStatus GetModification(ulong offset)
	    {
		    return this.m_backend.GetModification(offset);
	    }
	    
	    public override bool IsValidOffset(ulong offset)
	    {
		    return this.m_backend.IsValidOffset(offset);
	    }
	    
	    public override bool IsOffsetReadable(ulong offset)
	    {
		    return this.m_backend.IsOffsetReadable(offset);
	    }
	    
	    public override bool IsOffsetWritable(ulong offset)
	    {
		    return this.m_backend.IsOffsetWritable(offset);
	    }
	    
	    public override bool IsOffsetExecutable(ulong offset)
	    {
		    return this.m_backend.IsOffsetExecutable(offset);
	    }
	    
	    public override bool IsOffsetBackedByFile(ulong offset)
	    {
		    return this.m_backend.IsOffsetBackedByFile(offset);
	    }
	    
	    public override ulong GetNextValidOffset(ulong offset)
	    {
		    return this.m_backend.GetNextValidOffset(offset);
	    }
	    
	    public override ulong Start
	    {
		    get
		    {
			    return this.m_backend.Start;
		    }
	    }
	    
	    public override ulong Length
	    {
		    get
		    {
			    return this.m_backend.Length;
		    }
	    }
	    
	    public override ulong EntryPoint
	    {
		    get
		    {
			    return this.m_backend.EntryPoint;
		    }
	    }
	    
	    public override bool Executable
	    {
		    get
		    {
			    return this.m_backend.Executable;
		    }
	    }
	    
	    public override Endianness DefaultEndianness
	    {
		    get
		    {
			    return this.m_backend.DefaultEndiannes;
		    }
	    }
	    
	    public override bool Relocatable
	    {
		    get
		    {
			    return this.m_backend.Relocatable;
		    }
	    }
	    
	    public override ulong AddressSize
	    {
		    get
		    {
			    return this.m_backend.AddressSize;
		    }
	    }
	    
	    public override bool Save(FileAccessor accessor)
	    {
		    return this.m_backend.SaveToFile(accessor);
	    }
	}
}
