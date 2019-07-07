namespace NArr.Internals
{
    using System;

    internal static class Move
    {
        /// <summary>
        /// Moves a collection of elements in an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="from">The index of the first element in the desired collection</param>
        /// <param name="count">The number of elements in the desired collection</param>
        /// <param name="to">The index to which the collection will be moved</param>
        private static void SafeCall<T>(ref T[] array, int from, int count, int to)
        {
            T[] result = new T[array.Length];
            int current = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == from + current && i < from + count)
                {
                    result[to + current] = array[i];
                    current++;
                }
                else if (i >= from + count && i != to + count)
                {
                    result[i - count] = array[i];
                }
                else
                {
                    result[i] = array[i];
                }
            }

            array = result;
        }

        /// <summary>
        /// Moves a collection of elements in an array
        /// </summary>
        /// <typeparam name="T">array</typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="from">The index of the first element in the desired collection</param>
        /// <param name="count">The number of elements in the desired collection</param>
        /// <param name="to">The index to which the collection will be moved</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">from</exception>
        /// <exception cref="ArgumentOutOfRangeException">to</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        public static void Call<T>(ref T[] array, int from, int count, int to)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("Argument value is empty", nameof(array));
            }
            if (from > array.Length - 1 || from < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(from), "Argument value is outside the bounds of the array");
            }
            if (to + count > array.Length || to < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(to), "Argument value is outside the bounds of the array");
            }
            if (count > array.Length - from || count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Argument value is outside the bounds of the array");
            }
            if (from == to || count == 0 || array.Length == 1)
            {
                return;
            }

            SafeCall(ref array, from, count, to);
        }
    }
}
