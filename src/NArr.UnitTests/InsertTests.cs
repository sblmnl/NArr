namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class InsertTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Insert_IsExpected()
        {
            int[] array = { 0, 1, 2, 5, 6, 7 };
            int[] collection = { 3, 4 };
            int index = 3;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };

            narr.Insert(ref array, collection, index);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Insert_IndexIsTooLarge()
        {
            int[] array = { };
            int[] collection = { };
            int index = 1;

            Assert.Throws<Exception>(() => narr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_IndexIsTooSmall()
        {
            int[] array = { };
            int[] collection = { };
            int index = -1;

            Assert.Throws<Exception>(() => narr.Insert(ref array, collection, index));
        }
    }
}
