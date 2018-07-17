namespace NArr.Internals
{
    using System;

    internal static class Find
    {
        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to search.</param>
        /// <param name="collection">The collection to find.</param>
        /// <returns>Int32[]</returns>
        public static int[] Call<T>(this T[] array, T[] collection)
        {
            if (array.Length == 0) throw new Exception($"The length of '{nameof(array)}' cannot be 0.", new ArgumentNullException());
            if (collection.Length == 0) throw new Exception($"The length of '{nameof(collection)}' cannot be 0.", new ArgumentNullException());
            if (collection.Length > array.Length) throw new Exception($"The size of '{nameof(collection)}' cannot be larger than that of '{nameof(array)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[0];

            for (int i = 0; i < array.Length; i++)
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

                    if (match)
                    {
                        global::NArr.Internals.Resize.Call(ref results, results.Length + 1);
                        results[results.Length - 1] = i;
                        i += collection.Length - 1;
                    }
                }
            }

            return results;
        }
    }
}
