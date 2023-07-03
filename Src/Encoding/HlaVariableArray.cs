using System;

namespace Neoxio.HlaSharp.Encoding
{
    public class HlaVariableArray<TElement> : DataElement where TElement : DataElement
    {
        public int Size
        {
            get
            {
                throw new System.NotImplementedException("This is a reference assembly.");
            }
        }

        public Type PrototypeType
        {
            get
            {
                throw new System.NotImplementedException("This is a reference assembly.");
            }
        }

        public HlaVariableArray(TElement prototype)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override DataElement Clone()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool HasPrototypeSameTypeAs(DataElement dataElement)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AddElement(TElement element)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AddElementRef(TElement element)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetElement(int index, TElement element)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetElementRef(int index, TElement element)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public TElement GetElementCopy(int index)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected override void Dispose(bool disposing)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}