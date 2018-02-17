using System;

namespace TeamRandomizer
{
    /// <summary>
    /// Default random implementation based on the framework <see cref="Random"/>
    /// </summary>
    /// <seealso cref="TeamRandomizer.IRandom" />
    public class DefaultRandom : IRandom
    {
        private Random _random;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRandom"/> class.
        /// </summary>
        public DefaultRandom()
        {
            _random = new Random();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRandom"/> class.
        /// </summary>
        /// <param name="seed">The seed.</param>
        public DefaultRandom(int seed)
        {
            _random = new Random(seed);
        }

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
            return _random.Next(minValue, maxValue);
        }
    }
}
