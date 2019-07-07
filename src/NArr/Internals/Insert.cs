namespace NArr.Internals
{
    using System;

    internal static class Insert
    {
        /// <summary>
        /// Inserts a collection of elements into an array
        /// </summary>
        /// <typeparam name="T">The element type of the array and collection</typeparam>
        /// <param name="array">The array to insert into</param>
        /// <param name="collection">The collection to insert</param>
        /// <param name="index">The index to insert at</param>
        private static void SafeCall<T>(ref T[] array, T[] collection, int index)
        {
            Resize.Call(ref array, array.Length + collection.Length);

            for (int i = array.Length - 1; i >= index; i--)
            {
                if (i == index)
                {
                    for (int j = 0; j < collection.Length; j++)
                    {
                        array[i + j] = collection[j];
                    }
                }
                else
                {
                    if (!(i < collection.Length))
                    {
                        array[i] = array[i - collection.Length];
                    }
                }
            }
        }

        /// <summary>
        /// Inserts a collection of elements into an array.
        /// </summary>
        /// <typeparam name="T">The element type of the array and collection</typeparam>
        /// <param name="array">The array to insert into</param>
        /// <param name="collection">The collection to insert</param>
        /// <param name="index">The index to insert at</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentNullException">collection</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        public static void Call<T>(ref T[] array, T[] collection, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection), "Argument value is null");
            }
            if (index > array.Length || index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Argument value is outside the bounds of the array");
            }
            if (collection.Length == 0)
            {
                return;
            }

            SafeCall(ref array, collection, index);
        }
    }
}
