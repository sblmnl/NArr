using System;

namespace NArr.Internals
{
    internal static class Fragment
    {
        /// <summary>
        /// Divides an array into fragments of a maximum desired size
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to fragment</param>
        /// <param name="size">The maximum desired size of each fragment</param>
        private static T[][] SafeCall<T>(T[] array, int size)
        {
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

        /// <summary>
        /// Divides an array into fragments of a maximum desired size
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to fragment</param>
        /// <param name="size">The maximum desired size of each fragment</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">size</exception>
        public static T[][] Call<T>(T[] array, int size)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Argument value is null");
            }
            if (size > array.Length || size < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Argument value is outside the bounds of the array");
            }
            if (array.Length == 0)
            {
                return new T[][] { };
            }

            return SafeCall(array, size);
        }
    }
}
