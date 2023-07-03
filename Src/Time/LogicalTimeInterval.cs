using System;
using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp.Time
{
    public abstract class LogicalTimeInterval : UnmanagedHlaObject
    {
        public string ImplementationName()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetZero()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsZero()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetEpsilon()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsEpsilon()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetToDifference(LogicalTime minuend, LogicalTime subtrahend)
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

        public void Decode(VariableLengthData encodedValue)
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

        protected bool IsGreaterThan(LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected bool IsLowerThan(LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool Equals(LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public abstract override int GetHashCode();

        public static bool operator >(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator <(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator ==(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator !=(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator >=(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static bool operator <=(LogicalTimeInterval t1, LogicalTimeInterval t2)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}