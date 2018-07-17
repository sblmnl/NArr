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
    }
}
