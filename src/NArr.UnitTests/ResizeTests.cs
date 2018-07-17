namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ResizeTests
    {
        private static readonly NArr.Framework NArr = new NArr.Framework();

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
        public void Resize_NewSizeLessThanZero()
        {
            int[] array = { 0 };
            int newSize = -1;

            Assert.Throws<Exception>(() => NArr.Resize(ref array, newSize));
        }
    }
}
