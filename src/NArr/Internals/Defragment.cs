namespace NArr.Internals
{
    internal static class Defragment
    {
        /// <summary>
        /// Reconstructs a collection of fragments into its original array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fragments">The collection fragments to be reconstructed.</param>
        /// <returns>T[]</returns>
        public static T[] Call<T>(T[][] fragments)
        {
            int size = 0;
            for (int fragment = 0; fragment < fragments.Length; fragment++)
                size += fragments[fragment].Length;

            T[] array = new T[size];
            int write = 0;

            for (int fragment = 0; fragment < fragments.Length; fragment++)
            {
                for (int read = 0; read < fragments[fragment].Length; read++)
                {
                    array[write] = fragments[fragment][read];
                    write++;
                }
            }

            return array;
        }
    }
}
