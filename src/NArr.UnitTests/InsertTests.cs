namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class InsertTests
    {
        private static readonly NArr.Framework NArr = new NArr.Framework();

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
        public void Insert_IndexIsTooLarge()
        {
            int[] array = { };
            int[] collection = { };
            int index = 1;

            Assert.Throws<Exception>(() => NArr.Insert(ref array, collection, index));
        }

        [Test]
        public void Insert_IndexIsTooSmall()
        {
            int[] array = { };
            int[] collection = { };
            int index = -1;

            Assert.Throws<Exception>(() => NArr.Insert(ref array, collection, index));
        }
    }
}
