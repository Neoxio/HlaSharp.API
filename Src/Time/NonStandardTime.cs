using System;

namespace Neoxio.HlaSharp.Time
{
    public sealed class NonStandardTime : LogicalTime
    {
        public override int GetHashCode()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}