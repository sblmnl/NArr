namespace NArr.Internals
{
    using System;

    internal static class Remove
    {
        /// <summary>
        /// Removes a collection of elements from an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to manipulate.</param>
        /// <param name="count">The number of elements to remove.</param>
        /// <param name="index">The index of the first element in the desired collection to be removed.</param>
        public static void Call<T>(ref T[] array, int count, int index)
        {
            if (array.Length == 0 || array == null) throw new ArgumentNullException($"{nameof(array)}", "The array is empty!");
            if (count < 0) throw new ArgumentOutOfRangeException($"{nameof(count)}", "The number of elements is negative!");
            if (count + index > array.Length) throw new ArgumentOutOfRangeException($"{nameof(count)}", "The number of elements starting from the index exceeds the bounds of the array!");
            if (index < 0) throw new ArgumentOutOfRangeException($"{nameof(index)}", "The starting index is outside the bounds of the array! That doesn't exist...");
            if (index > array.Length - 1) throw new ArgumentOutOfRangeException($"{nameof(index)}", "The starting index is outside the bounds of the array!");
            if (count == 0) return;

            for (int i = index; i < array.Length; i++)
                if (i == index)
                    i += count - 1;
                else
                    array[i - count] = array[i];

            global::NArr.Internals.Resize.Call(ref array, array.Length - count);
        }
    }
}
