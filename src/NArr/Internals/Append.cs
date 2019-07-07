namespace NArr.Internals
{
    using System;

    internal static class Append
    {
        /// <summary>
        /// Appends a collection of elements to an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to append to.</param>
        /// <param name="collection">The collection to append.</param>
        public static void SafeCall<T>(ref T[] array, T[] collection)
        {
            Resize.Call(ref array, array.Length + collection.Length);

            for (int i = 0; i < collection.Length; i++)
            {
                array[(array.Length - collection.Length) + i] = collection[i];
            }
        }

        /// <summary>
        /// Appends a collection of elements to an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to append to.</param>
        /// <param name="collection">The collection to append.</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentNullException">collection</exception>
        public static void Call<T>(ref T[] array, T[] collection)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection), "Argument value is null");
            }

            SafeCall(ref array, collection);
        }
    }
}