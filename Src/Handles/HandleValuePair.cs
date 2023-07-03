using System;

namespace Neoxio.HlaSharp.Handles
{
    public struct HandleValuePair
    {
        public IntPtr handlePtr;

        public long hashCode;

        public IntPtr valuePtr;
    }
}