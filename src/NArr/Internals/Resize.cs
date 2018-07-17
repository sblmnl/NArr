namespace NArr.Internals
{
    using System;

    internal static class Resize
    {
        /// <summary>
        /// Resizes an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to resize.</param>
        /// <param name="newSize">The desired size of the array.</param>
        public static void Call<T>(ref T[] array, int newSize)
        {
            if (array.Length == newSize) return;
            if (newSize < 0) throw new Exception($"The value of '{nameof(newSize)}' cannot be less than 0.");

            T[] result = new T[newSize];

            if (newSize > array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[i];
                }
            }
            else if (newSize < array.Length)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = array[i];
                }
            }

            array = result;
        }
    }
}
