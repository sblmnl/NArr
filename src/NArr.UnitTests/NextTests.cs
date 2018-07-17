namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class NextTests
    {
        private static readonly NArr.Framework NArr = new NArr.Framework();

        [Test]
        public void Find_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            int[] collection = { 3 };
            int index = 2;

            int expected = 3;
            int result = NArr.Next(array, collection, index);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Find_EmptyArray()
        {
            int[] array = { };
            int[] collection = { 0 };
            int index = 0;

            Assert.Throws<Exception>(() => NArr.Next(array, collection, index));
        }

        [Test]
        public void Find_EmptyCollection()
        {
            int[] array = { 0 };
            int[] collection = { };
            int index = 0;

            Assert.Throws<Exception>(() => NArr.Next(array, collection, index));
        }

        [Test]
        public void Find_CollectionIsLargerThanArray()
        {
            int[] array = { 0 };
            int[] collection = { 0, 0 };
            int index = 0;

            Assert.Throws<Exception>(() => NArr.Next(array, collection, index));
        }

        [Test]
        public void Find_IndexExceedsArrayLength()
        {
            int[] array = { 0 };
            int[] collection = { 0 };
            int index = 1;

            Assert.Throws<Exception>(() => NArr.Next(array, collection, index));
        }

        [Test]
        public void Find_IndexIsLessThanZero()
        {
            int[] array = { 0 };
            int[] collection = { 0 };
            int index = -1;

            Assert.Throws<Exception>(() => NArr.Next(array, collection, index));
        }
    }
}
