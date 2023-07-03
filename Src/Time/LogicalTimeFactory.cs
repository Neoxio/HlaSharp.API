using System;
using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp.Time
{
    public abstract class LogicalTimeFactory : UnmanagedHlaObject
    {
        public LogicalTime MakeInitial()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTime MakeFinal()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTimeInterval MakeZero()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTimeInterval MakeEpsilon()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTime DecodeLogicalTime(VariableLengthData encodedLogicalTime)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTime DecodeLogicalTime(byte[] buffer, int offset = 0)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTimeInterval DecodeLogicalTimeInterval(VariableLengthData encodedValue)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public LogicalTimeInterval DecodeLogicalTimeInterval(byte[] buffer, int offset = 0)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public string GetName()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}