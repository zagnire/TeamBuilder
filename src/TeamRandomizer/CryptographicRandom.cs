using System;
using System.Security.Cryptography;

namespace TeamRandomizer
{
    /// <summary>
    /// A cryptographic random based on <see cref="RNGCryptoServiceProvider"/>
    /// </summary>
    /// <seealso cref="TeamRandomizer.IRandom" />
    public class CryptographicRandom : IRandom
    {
        RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

        /// <summary>
        /// returns the next random value between <paramref name="minValue" /> and <paramref name="maxValue" />.
        /// </summary>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>
        /// next random value
        /// </returns>
        public int Next(int minValue, int maxValue)
        {
            uint scale = uint.MaxValue;

            while (scale == uint.MaxValue)
            {
                // Get four random bytes
                byte[] bytes = new byte[4];
                _rng.GetBytes(bytes);

                // Convert bytes into an uint
                scale = BitConverter.ToUInt32(bytes, 0);
            }

            // Add min to the scaled difference between max and min 
            return (int)(minValue + (maxValue - minValue) * scale / (double)uint.MaxValue);
        }
    }
}

