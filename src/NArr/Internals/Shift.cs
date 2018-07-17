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
        public static void Call<T>(ref T[] array, int count)
        {
            if (array.Length == 0) throw new Exception($"The length of '{nameof(array)}' cannot be 0.", new ArgumentNullException());
            if (count < (array.Length * -1)) throw new Exception($"The value of '{nameof(count)}' cannot be less than {array.Length * -1}.", new ArgumentOutOfRangeException());
            if (count > array.Length) throw new Exception($"The value of '{nameof(count)}' cannot be greater than {array.Length}.", new ArgumentOutOfRangeException());
            if (count == 0 || count == array.Length || count == array.Length * -1 || array.Length == 1) return;
            if (count < 0) count = (array.Length - (count * -1));

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
    }
}
