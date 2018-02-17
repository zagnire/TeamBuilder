namespace TeamRandomizer
{
    /// <summary>
    /// Random Interface to choose/implement different "random" methods
    /// </summary>
    public interface IRandom
    {
        /// <summary>
        /// returns the next random value between <paramref name="minValue"/> and <paramref name="maxValue"/>.
        /// </summary>
        /// <param name="minValue">The minimum value.</param>
        /// <param name="maxValue">The maximum value.</param>
        /// <returns>next random value</returns>
        int Next(int minValue, int maxValue);
    }
}
