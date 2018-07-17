namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class FindTests
    {
        private static readonly NArr.Framework NArr = new NArr.Framework();

        [Test]
        public void Find_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            int[] collection = { 3 };

            int[] expected = { 3, 4 };
            int[] result = NArr.Find(array, collection);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Find_EmptyArray()
        {
            int[] array = { };
            int[] collection = { 0 };

            Assert.Throws<Exception>(() => NArr.Find(array, collection));
        }

        [Test]
        public void Find_CollectionIsLargerThanArray()
        {
            int[] array = { 0 };
            int[] collection = { 0, 0 };

            Assert.Throws<Exception>(() => NArr.Find(array, collection));
        }
    }
}
