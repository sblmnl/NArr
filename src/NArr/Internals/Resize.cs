namespace NArr.Internals
{
    using System;

    internal static class Resize
    {
        /// <summary>
        /// Resizes an array.
        /// </summary>
        /// <typeparam name="T">array</typeparam>
        /// <param name="array">The array to resize.</param>
        /// <param name="newSize">The desired size of the array.</param>
        private static void SafeCall<T>(ref T[] array, int newSize)
        {
            T[] result = new T[newSize];

            if (newSize > array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[i];
                }
            }
            else if (newSize < array.Length)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array[i];
                }
            }

            array = result;
        }

        /// <summary>
        /// Resizes an array.
        /// </summary>
        /// <typeparam name="T">array</typeparam>
        /// <param name="array">The array to resize.</param>
        /// <param name="newSize">The desired size of the array.</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">array</exception>
        public static void Call<T>(ref T[] array, int newSize)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (newSize < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newSize), "Argument value is outside the bounds of the array");
            }
            if (array.Length == newSize)
            {
                return;
            }

            SafeCall(ref array, newSize);
        }
    }
}
