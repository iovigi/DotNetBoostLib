namespace DotNetBoostLib.Utils
{
    using System;

    public static class BitConverterExtended
    {
        public static byte[] GetLittleEndian(long value)
        {
            if(BitConverter.IsLittleEndian)
            {
                return BitConverter.GetBytes(value);
            }

            var buffer = BitConverter.GetBytes(value);
            Array.Reverse(buffer);

            return buffer;
        }

        public static string GetLittleEndianAsString(long value)
        {
            return string.Join("", GetLittleEndian(value));
        }
    }
}
