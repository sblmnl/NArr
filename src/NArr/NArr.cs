namespace NArr
{
    using System;

    public static class NArr
    {
        /// <summary>
        /// Resizes an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to resize</param>
        /// <param name="newSize">The desired size of the array</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">newSize</exception>
        public static void Resize<T>(ref T[] array, int newSize)
        {
            Internals.Resize.Call(ref array, newSize);
        }

        /// <summary>
        /// Appends a collection of elements to an array
        /// </summary>
        /// <typeparam name="T">The element type of the array and collection</typeparam>
        /// <param name="array">The array to append to</param>
        /// <param name="collection">The collection to append</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentNullException">collection</exception>
        public static void Append<T>(ref T[] array, T[] collection)
        {
            Internals.Append.Call(ref array, collection);
        }

        /// <summary>
        /// Inserts a collection of elements into an array
        /// </summary>
        /// <typeparam name="T">The element type of the array and collection</typeparam>
        /// <param name="array">The array to insert into</param>
        /// <param name="collection">The collection to insert</param>
        /// <param name="index">The index to insert at</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentNullException">collection</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        public static void Insert<T>(ref T[] array, T[] collection, int index)
        {
            Internals.Insert.Call(ref array, collection, index);
        }

        /// <summary>
        /// Moves a collection of elements in an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="from">The index of the first element in the desired collection</param>
        /// <param name="count">The number of elements in the desired collection</param>
        /// <param name="to">The index to which the collection will be moved</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">from</exception>
        /// <exception cref="ArgumentOutOfRangeException">to</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        public static void Move<T>(ref T[] array, int from, int count, int to)
        {
            Internals.Move.Call(ref array, from, count, to);
        }

        /// <summary>
        /// Shifts the elements in an array by a certain number of indexes
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to shift</param>
        /// <param name="count">The number of indexes to shift by</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        public static void Shift<T>(ref T[] array, int count)
        {
            Internals.Shift.Call(ref array, count);
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array
        /// </summary>
        /// <typeparam name="T">The element type of the haystack and needle</typeparam>
        /// <param name="haystack">The array to search</param>
        /// <param name="needle">The collection to find</param>
        /// <param name="count">The number of elements to find (0 for all)</param>
        /// <param name="index">The index to begin searching from</param>
        /// <exception cref="ArgumentNullException">haystack</exception>
        /// <exception cref="ArgumentNullException">needle</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        /// <returns><see cref="System.Int32[]"/></returns>
        public static int[] Search<T>(this T[] haystack, T[] needle, int count = 0, int index = 0)
        {
            int[] results = null;
            switch (haystack.GetType().ToString())
            {
                case "System.Byte[]":
                    results = Internals.Search.Call((byte[])(object)haystack, (byte[])(object)needle, count, index);
                    break;
                case "System.SByte[]":
                    results = Internals.Search.Call((sbyte[])(object)haystack, (sbyte[])(object)needle, count, index);
                    break;
                case "System.Boolean[]":
                    results = Internals.Search.Call((bool[])(object)haystack, (bool[])(object)needle, count, index);
                    break;
                case "System.Char[]":
                    results = Internals.Search.Call((char[])(object)haystack, (char[])(object)needle, count, index);
                    break;
                case "System.Int16[]":
                    results = Internals.Search.Call((short[])(object)haystack, (short[])(object)needle, count, index);
                    break;
                case "System.UInt16[]":
                    results = Internals.Search.Call((ushort[])(object)haystack, (ushort[])(object)needle, count, index);
                    break;
                case "System.Int32[]":
                    results = Internals.Search.Call((int[])(object)haystack, (int[])(object)needle, count, index);
                    break;
                case "System.UInt32[]":
                    results = Internals.Search.Call((uint[])(object)haystack, (uint[])(object)needle, count, index);
                    break;
                case "System.Int64[]":
                    results = Internals.Search.Call((long[])(object)haystack, (long[])(object)needle, count, index);
                    break;
                case "System.UInt64[]":
                    results = Internals.Search.Call((ulong[])(object)haystack, (ulong[])(object)needle, count, index);
                    break;
                case "System.Single[]":
                    results = Internals.Search.Call((float[])(object)haystack, (float[])(object)needle, count, index);
                    break;
                case "System.Double[]":
                    results = Internals.Search.Call((double[])(object)haystack, (double[])(object)needle, count, index);
                    break;
                case "System.Decimal[]":
                    results = Internals.Search.Call((decimal[])(object)haystack, (decimal[])(object)needle, count, index);
                    break;
                case "System.String[]":
                    results = Internals.Search.Call((string[])(object)haystack, (string[])(object)needle, count, index);
                    break;
                default:
                    results = Internals.Search.Call(haystack, needle, count, index);
                    break;
            }

            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array
        /// </summary>
        /// <typeparam name="T">The element type of the haystack</typeparam>
        /// <param name="haystack">The array to search</param>
        /// <param name="match">The expression for the elements to match</param>
        /// <param name="count">The number of elements to find (0 for all)</param>
        /// <param name="index">The index to begin searching from</param>
        /// <exception cref="ArgumentNullException">haystack</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        /// <returns><see cref="System.Int32[]"/></returns>
        public static int[] Search<T>(this T[] haystack, Func<T, bool> match, int count = 0, int index = 0)
        {
            return Internals.Search.Call(haystack, match, count, index);
        }

        /// <summary>
        /// Removes a collection of elements from an array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to manipulate</param>
        /// <param name="count">The number of elements to remove</param>
        /// <param name="index">The index of the first element in the desired collection to be removed</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        public static void Remove<T>(ref T[] array, int count, int index)
        {
            Internals.Remove.Call(ref array, count, index);
        }


        /// <summary>
        /// Divides an array into fragments of a maximum desired size
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="array">The array to fragment</param>
        /// <param name="size">The maximum desired size of each fragment</param>
        /// <exception cref="ArgumentNullException">array</exception>
        /// <exception cref="ArgumentOutOfRangeException">size</exception>
        public static T[][] Fragment<T>(this T[] array, int size)
        {
            return Internals.Fragment.Call(array, size);
        }

        /// <summary>
        /// Reconstructs a collection of fragments into its original array
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        /// <param name="fragments">The collection fragments to be reconstructed</param>
        /// <exception cref="ArgumentNullException">fragments</exception>
        public static T[] Defragment<T>(this T[][] fragments)
        {
            return Internals.Defragment.Call(fragments);
        }
    }
}
