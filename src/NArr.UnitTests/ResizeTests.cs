namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ResizeTests
    {
        [Test]
        public void Resize_IncreaseSize_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int newSize = 9;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 0 };
            NArr.Resize(ref array, newSize);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Resize_DecreaseSize_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int newSize = 7;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6 };
            NArr.Resize(ref array, newSize);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Resize_NullArray()
        {
            int[] array = null;
            int newSize = 1;

            Assert.Throws<ArgumentNullException>(() => NArr.Resize(ref array, newSize));
        }

        [Test]
        public void Resize_NewSizeLessThanZero()
        {
            int[] array = { 0 };
            int newSize = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Resize(ref array, newSize));
        }

        public void Resize_ArrayLengthEqualsNewSize()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int newSize = 8;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };
            NArr.Resize(ref array, newSize);

            Assert.AreEqual(expected, array);
        }
    }
}
