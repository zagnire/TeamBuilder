using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer
{
    public class CryptographicRandom : IRandom
    {

        RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();

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

