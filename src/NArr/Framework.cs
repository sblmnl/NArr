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
        /// <returns>System.Int32[]</returns>
        public int[] Find(byte[] haystack, byte[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(sbyte[] haystack, sbyte[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(bool[] haystack, bool[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(char[] haystack, char[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(short[] haystack, short[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(ushort[] haystack, ushort[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(int[] haystack, int[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(uint[] haystack, uint[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(long[] haystack, long[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(ulong[] haystack, ulong[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(float[] haystack, float[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(double[] haystack, double[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(decimal[] haystack, decimal[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find(string[] haystack, string[] needle)
        {
            return global::NArr.Internals.Find.Call(haystack, needle);
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The predicate for the elements to match.</param>
        /// <returns>System.Int32[]</returns>
        public int[] Find<T>(T[] haystack, Predicate<T> match)
        {
            return global::NArr.Internals.Find.Call(haystack, match);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(byte[] haystack, byte[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(sbyte[] haystack, sbyte[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(bool[] haystack, bool[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(char[] haystack, char[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(short[] haystack, short[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(ushort[] haystack, ushort[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(int[] haystack, int[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(uint[] haystack, uint[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(long[] haystack, long[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(ulong[] haystack, ulong[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(float[] haystack, float[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(double[] haystack, double[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(decimal[] haystack, decimal[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next(string[] haystack, string[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next<T>(T[] haystack, T[] needle, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, needle, index);
        }

        /// <summary>
        /// Finds next occurence index of an element in an array that matches the conditions of a predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The conditions for an element to match.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public int Next<T>(T[] haystack, Predicate<T> match, int index)
        {
            return global::NArr.Internals.Next.Call(haystack, match, index);
        }
}
}
