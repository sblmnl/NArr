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
            int[] haystack = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            int[] needle = { 3 };

            int[] expected = { 3, 4 };
            int[] result = narr.Find(haystack, needle);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Find_EmptyArray()
        {
            int[] haystack = { };
            int[] needle = { 0 };

            Assert.Throws<Exception>(() => narr.Find(haystack, needle));
        }

        [Test]
        public void Find_CollectionIsLargerThanArray()
        {
            int[] haystack = { 0 };
            int[] needle = { 0, 0 };

            Assert.Throws<Exception>(() => narr.Find(haystack, needle));
        }
    }
}
