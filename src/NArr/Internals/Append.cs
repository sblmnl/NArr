namespace NArr.Internals
{
    internal static class Append
    {
        /// <summary>
        /// Appends a collection of elements to an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to append to.</param>
        /// <param name="collection">The collection to append.</param>
        public static void Call<T>(ref T[] array, T[] collection)
        {
            global::NArr.Internals.Resize.Call(ref array, array.Length + collection.Length);

            for (int i = 0; i < collection.Length; i++)
            {
                array[(array.Length - collection.Length) + i] = collection[i];
            }
        }
    }
}