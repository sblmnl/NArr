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
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to search.</param>
        /// <param name="collection">The collection to find.</param>
        /// <returns>Int32[]</returns>
        public int[] Find<T>(T[] array, T[] collection)
        {
            return global::NArr.Internals.Find.Call(array, collection);
        }

        /// <summary>
        /// Finds next occurrence index of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">The array to search.</param>
        /// <param name="collection">The collection to find.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>Int32</returns>
        public int Next<T>(T[] array, T[] collection, int index)
        {
            return global::NArr.Internals.Next.Call(array, collection, index);
        }
    }
}
