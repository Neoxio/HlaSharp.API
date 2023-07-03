namespace Neoxio.HlaSharp.Encoding
{
    public interface IEncodable
    {
        void Encode(VariableLengthData inData);

        void Decode(VariableLengthData inData);
    }
}