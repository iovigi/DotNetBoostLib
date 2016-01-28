namespace DotNetBoostLib.Utils
{
    using System;
    using System.Text;

    public static class ByteArrayExtensions
    {
        public static string ToHex(this byte[] buffer)
        {
            if(buffer == null)
            {
                throw new ArgumentNullException("buffer can't be null");
            }

            StringBuilder result = new StringBuilder();

            foreach(var item in buffer)
            {
                var hexOutput = string.Format("{0:X}", item);
                result.Append(hexOutput);
            }

            return result.ToString();
        }
    }
}
