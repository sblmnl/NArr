namespace NArr.Internals
{
    using System;

    internal static class Select
    {
        /// <summary>
        /// Selects a range of elements from an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to select from</param>
        /// <param name="from">The index to start selecting from</param>
        /// <param name="to">The index to stop selecting at</param>
        private static T[] SafeCall<T>(T[] array, int from, int to)
        {
            T[] results;

            if (from > to)
            {
                results = new T[(from - to) + 1];

                for (int i = from; i > to - 1; i--)
                {
                    results[from - i] = array[i];
                }
            }
            else
            {
                results = new T[(to - from) + 1];

                for (int i = from; i < to + 1; i++)
                {
                    results[i - from] = array[i];
                }
            }

            return results;
        }

        /// <summary>
        /// Selects a range of elements from an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to select from</param>
        /// <param name="from">The index to start selecting from</param>
        /// <param name="to">The index to stop selecting at</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">from</exception>
        /// <exception cref="ArgumentOutOfRangeException">to</exception>
        public static T[] Call<T>(T[] array, int from, int to)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (from < 0 || from > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(from), "Argument value is outside the bounds of the array");
            }
            if (to < 0 || to > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(to), "Argument value is outside the bounds of the array");
            }

            return SafeCall(array, from, to);
        }
    }
}
