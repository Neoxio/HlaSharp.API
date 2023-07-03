using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp.Handles
{
    public sealed class ObjectInstanceHandle : UnmanagedHlaObject
    {
        public override int GetHashCode()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public long GetNativeHashCode(bool noCache = false)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public ObjectInstanceHandle Copy()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public long EncodedLength()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public VariableLengthData Encode()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void EncodeInto(VariableLengthData buffer)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public int Encode(byte[] buffer, int offset = 0)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator ==(ObjectInstanceHandle a, ObjectInstanceHandle b)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator !=(ObjectInstanceHandle a, ObjectInstanceHandle b)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool Equals(ObjectInstanceHandle other)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}