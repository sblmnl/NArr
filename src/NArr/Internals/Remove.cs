namespace NArr.Internals
{
    using System;

    internal static class Remove
    {
        /// <summary>
        /// Removes a collection of elements from an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="count">The number of elements to remove</param>
        /// <param name="index">The index of the first element in the desired collection to be removed</param>
        private static void SafeCall<T>(ref T[] array, int count, int index)
        {
            for (int i = index; i < array.Length; i++)
                if (i == index)
                    i += count - 1;
                else
                    array[i - count] = array[i];

            Resize.Call(ref array, array.Length - count);
        }

        /// <summary>
        /// Removes a collection of elements from an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="count">The number of elements to remove</param>
        /// <param name="index">The index of the first element in the desired collection to be removed</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        public static void Call<T>(ref T[] array, int count, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (count < 0 || count + index > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Argument value is outside the bounds of the array");
            }
            if (index < 0 || index > array.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Argument value is outside the bounds of the array");
            }
            if (array.Length == 0 || count == 0)
            {
                return;
            }

            SafeCall(ref array, count, index);
        }
    }
}
