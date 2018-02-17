using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer
{
    public class DefaultRandom : IRandom
    {
        private Random _random;

        public DefaultRandom()
        {
            _random = new Random();
        }

        public DefaultRandom(int seed)
        {
            _random = new Random(seed);
        }

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}
