using System;
using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp.Encoding
{
    public abstract class DataElement : UnmanagedHlaObject, IEncodable
    {
        public abstract DataElement Clone();

        public VariableLengthData Encode()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Encode(VariableLengthData inData)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EncodeInto(ByteVector buffer)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Decode(VariableLengthData inData)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public int DecodeFrom(ByteVector buffer, int index)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public int GetEncodedLength()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public uint GetOctetBoundary()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public virtual bool IsSameTypeAs(DataElement inData)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public long Hash()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}