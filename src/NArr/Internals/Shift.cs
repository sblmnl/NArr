namespace NArr.Internals
{
    using System;

    internal static class Shift
    {
        /// <summary>
        /// Shifts the elements in an array by a certain number of indexes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to shift.</param>
        /// <param name="count">The number of indexes to shift by.</param>
        private static void SafeCall<T>(ref T[] array, int count)
        {
            T[] result = new T[array.Length];

            int current = 0;

            for (int i = (array.Length - count); i < array.Length; i++)
            {
                result[current] = array[i];
                current++;
            }

            for (int i = 0; i < (array.Length - count); i++)
            {
                result[current] = array[i];
                current++;
            }

            array = result;
        }

        /// <summary>
        /// Shifts the elements in an array by a certain number of indexes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to shift.</param>
        /// <param name="count">The number of indexes to shift by.</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        public static void Call<T>(ref T[] array, int count)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (count < (array.Length * -1) || count > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Argument value is outside the bounds of the array");
            }
            if (count < 0)
            {
                count = (array.Length - (count * -1));
            }
            if (count == 0 || count == array.Length || count == array.Length * -1 || array.Length == 1)
            {
                return;
            }

            SafeCall(ref array, count);
        }
    }
}
