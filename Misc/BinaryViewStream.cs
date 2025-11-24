using System;
using System.IO;

namespace BinaryNinja
{
	public sealed class BinaryViewStream : Stream
	{
		private BinaryView   m_view;
		
		private long m_position = 0;
		
		private bool m_isReadOnly = false;
		
		public BinaryViewStream(
			BinaryView view , 
			bool isReadOnly = false 
		)
		{
			this.m_view = view;
		
			this.m_isReadOnly = isReadOnly;
		}

		public override void Flush()
		{
			
		}

		public override int Read(byte[] buffer , int offset , int count)
		{
			if (null == buffer)
			{
				throw new ArgumentNullException(nameof(buffer));
			}

			if ( ( offset < 0 ) || ( offset > buffer.Length )  )
			{
				throw new ArgumentOutOfRangeException(nameof(offset));
			}
			
			if ( ( count < 0) || ( count > (buffer.Length - offset) )  )
			{
				throw new ArgumentOutOfRangeException(nameof(count));
			}
			
			if (this.Position >= this.Length)
			{
				return 0;
			}
			
			long remaining = this.Length - this.Position;
			
			int toRead = (int)Math.Min(remaining, (long)count);

			if (toRead <= 0)
			{
				return 0;
			}
			
			byte[] data = this.m_view.ReadData( 
				(ulong)this.m_position,
				(ulong)toRead
			);

			if (( null == data ) || ( 0 == data.Length ))
			{
				return 0;
			}
			
			Array.Copy(
				data, 
				0, 
				buffer, 
				offset,
				data.Length
			);
			
			this.m_position += data.Length;
			
			return data.Length;
		}

		public override long Seek(long offset , SeekOrigin origin)
		{
			long pos =  this.m_position;

			switch (origin)
			{
				case SeekOrigin.Begin:
				{
					pos = offset;
					break;
				}

				case SeekOrigin.Current:
				{
					pos = this.m_position + offset;
					break;
				}

				case SeekOrigin.End:
				{
					pos = checked(this.Length + offset);
					break;
				}

				default:
				{
					throw new ArgumentOutOfRangeException(nameof(origin));
				}
			}

			if (pos < 0 )
			{
				throw new IOException();
			}
			
			this.m_position = pos;

			return this.m_position;
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer , int offset , int count)
		{
			if (null == buffer)
			{
				throw new ArgumentNullException(nameof(buffer));
			}

			if ( ( offset < 0 ) || ( offset > buffer.Length )  )
			{
				throw new ArgumentOutOfRangeException(nameof(offset));
			}
			
			if ( ( count < 0) || ( count > (buffer.Length - offset) ) )
			{
				throw new ArgumentOutOfRangeException(nameof(count));
			}

			if (this.m_position >= this.Length)
			{
				throw new IOException();
			}
			
			long remaining = this.Length - m_position;

			if (remaining <= 0)
			{
				return;
				//throw new IOException("Attempt to write past end of stream");
			}

			int toWrite = (int)Math.Min(remaining, (long)count);
			
			if (toWrite <= 0)
			{
				return;
			}
			
			byte[] slice = new byte[toWrite];
			
			Array.Copy(
				buffer, 
				offset, 
				slice,
				0, 
				toWrite
			);
			
			ulong written = this.m_view.WriteData(
				(ulong)this.m_position, 
				slice
			);

			if ((long)written != toWrite)
			{
				throw new IOException("Failed to write the expected number of bytes to the BinaryView.");
			}

			this.m_position += (long)written;
		}

		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		public override bool CanWrite
		{
			get
			{
				return !this.m_isReadOnly;
			}
		}

		public override long Length
		{
			get
			{
				return (long)this.m_view.Length;
			}
		}

		public override long Position
		{
			get
			{
				return this.m_position;
			}

			set
			{
				this.m_position = value;
			}
		}
	}
}
