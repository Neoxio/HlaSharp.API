using System;

namespace Neoxio.HlaSharp.Interop
{
    public abstract class UnmanagedHlaObject : IDisposable
    {
        public void Dispose()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected virtual void Dispose(bool disposing)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}