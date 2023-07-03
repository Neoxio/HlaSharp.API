using System;

namespace Neoxio.HlaSharp.Encoding
{
    public class HlaVariantRecord<TDiscriminant> : DataElement where TDiscriminant : DataElement
    {
        public Type DiscriminantType
        {
            get
            {
                throw new System.NotImplementedException("This is a reference assembly.");
            }
        }

        public HlaVariantRecord(TDiscriminant prototype)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public override DataElement Clone()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool IsSameTypeAs(TDiscriminant discriminant, DataElement inData)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public bool HasMatchingDiscriminantTypeAs(DataElement dataElement)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AddVariant(TDiscriminant discriminant, DataElement variant)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void AddVariantRef(TDiscriminant discriminant, DataElement variant)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetDiscriminant(TDiscriminant discriminant)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetVariant(TDiscriminant discriminant, DataElement variant)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public void SetVariantRef(TDiscriminant discriminant, DataElement variant)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public TDiscriminant GetDiscriminant()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public DataElement GetVariant()
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        protected override void Dispose(bool disposing)
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}