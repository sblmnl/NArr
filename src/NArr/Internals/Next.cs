namespace NArr.Internals
{
    using System;

    internal static class Next
    {
        /// <summary>
        /// Finds next occurrence index of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to search.</param>
        /// <param name="collection">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>Int32</returns>
        public static int Call<T>(this T[] array, T[] collection, int index)
        {
            if (array.Length == 0) throw new Exception($"The value of '{nameof(array)}' cannot be null.", new ArgumentNullException());
            if (collection.Length == 0) throw new Exception($"The value of '{nameof(collection)}' cannot be null.", new ArgumentNullException());
            if (collection.Length > array.Length) throw new Exception($"The size of '{nameof(collection)}' cannot be larger than that of '{nameof(array)}'.", new ArgumentOutOfRangeException());
            if (index > array.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {array.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

            for (int i = index; i < array.Length; i++)
            {
                T[] chunk = new T[collection.Length];

                if (Equals(array[i], collection[0])
                    && Equals(array[i + ((collection.Length - 1) / 2)], collection[(collection.Length - 1) / 2])
                    && Equals(array[i + (collection.Length - 1)], collection[collection.Length - 1]))
                {
                    for (int j = 0; j < chunk.Length; j++)
                    {
                        chunk[j] = array[i + j];
                    }

                    bool match = true;

                    for (int j = 0; j < chunk.Length; j++)
                    {
                        if (!Equals(chunk[j], collection[j]))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match) return i;
                }
            }

            return -1;
        }
    }
}
