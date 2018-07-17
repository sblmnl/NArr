namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class FindTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Find_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            int[] collection = { 3 };

            int[] expected = { 3, 4 };
            int[] result = narr.Find(array, collection);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Find_EmptyArray()
        {
            int[] array = { };
            int[] collection = { 0 };

            Assert.Throws<Exception>(() => narr.Find(array, collection));
        }

        [Test]
        public void Find_CollectionIsLargerThanArray()
        {
            int[] array = { 0 };
            int[] collection = { 0, 0 };

            Assert.Throws<Exception>(() => narr.Find(array, collection));
        }
    }
}
