namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class InsertTests
    {
        [Test]
        public void Insert_IsExpected()
        {
            int[] array = { 0, 1, 2, 5, 6, 7 };
            int[] collection = { 3, 4 };
            int index = 3;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };

            NArr.Insert(ref array, collection, index);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Insert_NullArray()
        {
            int[] array = null;
            int[] collection = { 3, 4 };
            int index = 3;

            Assert.Throws<ArgumentNullException>(() => NArr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_NullCollection()
        {
            int[] array = { 0, 1, 2, 5, 6, 7 };
            int[] collection = null;
            int index = 3;

            Assert.Throws<ArgumentNullException>(() => NArr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_IndexIsTooLarge()
        {
            int[] array = { };
            int[] collection = { };
            int index = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_IndexIsTooSmall()
        {
            int[] array = { };
            int[] collection = { };
            int index = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_EmptyCollection()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] collection = { };
            int index = 3;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };

            NArr.Insert(ref array, collection, index);

            Assert.AreEqual(expected, array);
        }
    }
}
