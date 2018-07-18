namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class NextTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Find_IsExpected()
        {
            int[] haystack = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            int[] needle = { 3 };
            int index = 2;

            int expected = 3;
            int result = narr.Next(haystack, needle, index);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Find_EmptyArray()
        {
            int[] haystack = { };
            int[] needle = { 0 };
            int index = 0;

            Assert.Throws<Exception>(() => narr.Next(haystack, needle, index));
        }

        [Test]
        public void Find_EmptyCollection()
        {
            int[] haystack = { 0 };
            int[] needle = { };
            int index = 0;

            Assert.Throws<Exception>(() => narr.Next(haystack, needle, index));
        }

        [Test]
        public void Find_CollectionIsLargerThanArray()
        {
            int[] haystack = { 0 };
            int[] needle = { 0, 0 };
            int index = 0;

            Assert.Throws<Exception>(() => narr.Next(haystack, needle, index));
        }

        [Test]
        public void Find_IndexExceedsArrayLength()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int index = 1;

            Assert.Throws<Exception>(() => narr.Next(haystack, needle, index));
        }

        [Test]
        public void Find_IndexIsLessThanZero()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int index = -1;

            Assert.Throws<Exception>(() => narr.Next(haystack, needle, index));
        }
    }
}
