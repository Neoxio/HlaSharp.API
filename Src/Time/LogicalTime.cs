using System;
using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp.Time
{
    public abstract class LogicalTime : UnmanagedHlaObject, IEquatable<LogicalTime>
    {
        public string ImplementationName()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsInitial()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsFinal()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetInitial()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetFinal()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public VariableLengthData Encode()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public int Encode(byte[] buffer, int offset = 0)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public int EncodedLength()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Decode(VariableLengthData encodedLogicalTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void Decode(byte[] buffer, int offset = 0)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override string ToString()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AddInterval(LogicalTimeInterval addend)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SubstractInterval(LogicalTimeInterval subtrahend)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected bool IsGreaterThan(LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected bool IsLowerThan(LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool Equals(LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public abstract override int GetHashCode();

        public static bool operator >(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator <(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator ==(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator !=(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator >=(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator <=(LogicalTime t1, LogicalTime t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}