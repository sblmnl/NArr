namespace NArr.Internals
{
    using System;

    internal static class Move
    {
        /// <summary>
        /// Moves a collection of elements in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to manipulate.</param>
        /// <param name="from">The index of the first element in the desired collection.</param>
        /// <param name="count">The number of elements in the desired collection.</param>
        /// <param name="to">The index to which the collection will be moved.</param>
        public static void Call<T>(ref T[] array, int from, int count, int to)
        {
            if (array.Length == 0) throw new Exception($"The length of '{nameof(array)}' cannot be 0.", new ArgumentNullException());
            if (from > array.Length - 1) throw new Exception($"The value of '{nameof(from)}' cannot be greater than {array.Length - 1}.", new ArgumentOutOfRangeException());
            if (from < 0) throw new Exception($"The value of '{nameof(from)}' cannot be less than 0.", new ArgumentOutOfRangeException());
            if (to + count > array.Length) throw new Exception($"The value of '{nameof(to)}' cannot be greater than {array.Length - count}.", new ArgumentOutOfRangeException());
            if (to < 0) throw new Exception($"The value of '{nameof(to)}' cannot be less than 0.", new ArgumentOutOfRangeException());
            if (count > array.Length - from) throw new Exception($"The value of '{nameof(count)}' cannot be greater than {array.Length - from}.", new ArgumentOutOfRangeException());
            if (count < 0) throw new Exception($"The value of '{nameof(count)}' cannot be less than 0.", new ArgumentOutOfRangeException());
            if (from == to || count == 0 || array.Length == 1 || array.Length == count) return;

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
    }
}
