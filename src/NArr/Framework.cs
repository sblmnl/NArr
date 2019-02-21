using System;

namespace NArr
{
    public class Framework
    {
        /// <summary>
        /// Resizes an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to resize.</param>
        /// <param name="newSize">The desired size of the array.</param>
        public void Resize<T>(ref T[] array, int newSize)
        {
            global::NArr.Internals.Resize.Call(ref array, newSize);
        }

        /// <summary>
        /// Appends a collection of elements to an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to append to.</param>
        /// <param name="collection">The collection to append.</param>
        public void Append<T>(ref T[] array, T[] collection)
        {
            global::NArr.Internals.Append.Call(ref array, collection);
        }

        /// <summary>
        /// Inserts a collection of elements into an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to insert into.</param>
        /// <param name="collection">The collection to insert.</param>
        /// <param name="index">The index to insert at.</param>
        public void Insert<T>(ref T[] array, T[] collection, int index)
        {
            global::NArr.Internals.Insert.Call(ref array, collection, index);
        }

        /// <summary>
        /// Moves a collection of elements in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to manipulate.</param>
        /// <param name="from">The index of the first element in the desired collection.</param>
        /// <param name="count">The number of elements in the desired collection.</param>
        /// <param name="to">The index to which the collection will be moved.</param>
        public void Move<T>(ref T[] array, int from, int count, int to)
        {
            global::NArr.Internals.Move.Call(ref array, from, count, to);
        }

        /// <summary>
        /// Shifts the elements in an array by a certain number of indexes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to shift.</param>
        /// <param name="count">The number of indexes to shift by.</param>
        public void Shift<T>(ref T[] array, int count)
        {
            global::NArr.Internals.Shift.Call(ref array, count);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(byte[] haystack, byte[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(sbyte[] haystack, sbyte[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(bool[] haystack, bool[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(char[] haystack, char[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(short[] haystack, short[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(ushort[] haystack, ushort[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(int[] haystack, int[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(uint[] haystack, uint[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(long[] haystack, long[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(ulong[] haystack, ulong[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(float[] haystack, float[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(double[] haystack, double[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(decimal[] haystack, decimal[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search(string[] haystack, string[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search<T>(T[] haystack, T[] needle, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, needle, count, index);
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The predicate for the elements to match.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Search<T>(T[] haystack, Predicate<T> match, int count = 0, int index = 0)
        {
            return global::NArr.Internals.Search.Call(haystack, match, count, index);
        }

        /// <summary>
        /// Removes a collection of elements from an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to manipulate.</param>
        /// <param name="count">The number of elements to remove.</param>
        /// <param name="index">The index of the first element in the desired collection to be removed.</param>
        public void Remove<T>(ref T[] array, int count, int index)
        {
            global::NArr.Internals.Remove.Call(ref array, count, index);
        }


        /// <summary>
        /// Divides an array into fragments of a maximum desired size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to fragment.</param>
        /// <param name="size">The maximum desired size of each fragment.</param>
        /// <returns>T[][]</returns>
        public T[][] Fragment<T>(T[] array, int size)
        {
            return global::NArr.Internals.Fragment.Call(array, size);
        }

        /// <summary>
        /// Reconstructs a collection of fragments into its original array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fragments">The collections of fragments to be reconstructed.</param>
        /// <returns>T[]</returns>
        public T[] Defragment<T>(T[][] fragments)
        {
            return global::NArr.Internals.Defragment.Call(fragments);
        }
    }
}
