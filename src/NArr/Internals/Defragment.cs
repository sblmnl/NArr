namespace NArr.Internals
{
    using System;

    internal static class Defragment
    {
        /// <summary>
        /// Reconstructs a collection of fragments into its original array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="fragments">The collection fragments to be reconstructed</param>
        private static T[] SafeCall<T>(T[][] fragments)
        {
            int size = 0;
            for (int fragment = 0; fragment < fragments.Length; fragment++)
            {
                size += fragments[fragment].Length;
            }

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

        /// <summary>
        /// Reconstructs a collection of fragments into its original array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="fragments">The collection fragments to be reconstructed</param>
        /// <exception cref="ArgumentNullException">fragments</exception>
        public static T[] Call<T>(T[][] fragments)
        {
            if (fragments == null)
            {
                throw new ArgumentNullException(nameof(fragments), "Argument value is null");
            }
            if (fragments.Length == 0)
            {
                return new T[] { };
            }

            return SafeCall(fragments);
        }
    }
}
