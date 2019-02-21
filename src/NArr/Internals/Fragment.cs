using System;

namespace NArr.Internals
{
    internal static class Fragment
    {
        /// <summary>
        /// Divides an array into fragments of a maximum desired size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to fragment.</param>
        /// <param name="size">The maximum desired size of each fragment.</param>
        /// <returns>T[][]</returns>
        public static T[][] Call<T>(T[] array, int size)
        {
            if (array.Length == 0) return new T[0][];
            if (size < 1) throw new ArgumentException($"The value of '{nameof(size)}' cannot be less than 1.");

            int fragment_count = array.Length / size;
            if ((double)array.Length / size > fragment_count) fragment_count++;

            int fragment_size = array.Length;
            if (size <= array.Length) fragment_size = size;

            T[][] fragments = new T[fragment_count][];
            T[] fragment = new T[fragment_size];

            int write = 0;
            int fragmented = 0;

            for (int read = 0; read < array.Length; read++)
            {
                if (read != 0 && read % size == 0)
                {
                    fragments[fragmented] = fragment;
                    fragmented++;

                    int remainder = array.Length - read;
                    if (remainder > size) fragment_size = size;
                    else fragment_size = remainder;

                    fragment = new T[fragment_size];
                    write = 0;
                }

                fragment[write] = array[read];
                write++;

                if (read == array.Length - 1)
                {
                    fragments[fragmented] = fragment;
                    break;
                }
            }

            return fragments;
        }
    }
}
