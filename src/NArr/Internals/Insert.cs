namespace NArr.Internals
{
    using System;

    internal static class Insert
    {
        /// <summary>
        /// Inserts a collection of elements into an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to insert into.</param>
        /// <param name="collection">The collection to insert.</param>
        /// <param name="index">The index to insert at.</param>
        public static void Call<T>(ref T[] array, T[] collection, int index)
        {
            if (index > array.Length) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {array.Length}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());
            if (collection.Length == 0) return;

            global::NArr.Internals.Resize.Call(ref array, array.Length + collection.Length);

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
    }
}
