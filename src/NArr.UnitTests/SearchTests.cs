namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SearchTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Search_TypeSearch_IsExpected()
        {
            int[] haystack = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] needle = { 3 };

            int[] expected = { 3 };
            int[] actual = narr.Search(
                haystack: haystack,
                needle: needle);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_ConditionSearch_IsExpected()
        {
            int[] haystack = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            Predicate<int> match = x => x == 3;

            int[] expected = { 3, 4 };
            int[] actual = narr.Search(haystack, match);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_TypeSearch_EmptyArray()
        {
            int[] haystack = { };
            int[] needle = { 0 };
            Assert.Throws<ArgumentNullException>(() => narr.Search(haystack, needle));
        }

        [Test]
        public void Search_TypeSearch_EmptyCollection()
        {
            int[] haystack = { 0 };
            int[] needle = { };
            Assert.Throws<ArgumentNullException>(() => narr.Search(haystack, needle));
        }

        [Test]
        public void Search_TypeSearch_CollectionIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0, 0 };
            Assert.Throws<ArgumentException>(() => narr.Search(haystack, needle));
        }

        [Test]
        public void Search_TypeSearch_CountIsTooSmall()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, needle, count));
        }

        [Test]
        public void Search_TypeSearch_CountIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 2;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, needle, count));
        }

        [Test]
        public void Search_TypeSearch_IndexIsTooSmall()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 0;
            int index = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, needle, count, index));
        }

        [Test]
        public void Search_TypeSearch_IndexIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 0;
            int index = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, needle, count, index));
        }

        [Test]
        public void Search_ConditionSearch_EmptyArray()
        {
            int[] haystack = { };
            Predicate<int> match = x => x == 0;
            Assert.Throws<ArgumentNullException>(() => narr.Search(haystack, match));
        }

        [Test]
        public void Search_ConditionSearch_CountIsTooSmall()
        {
            int[] haystack = { 0 };
            Predicate<int> match = x => x == 0;
            int count = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, match, count));
        }

        [Test]
        public void Search_ConditionSearch_CountIsTooLarge()
        {
            int[] haystack = { 0 };
            Predicate<int> match = x => x == 0;
            int count = 2;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, match, count));
        }

        [Test]
        public void Search_ConditionSearch_IndexIsTooSmall()
        {
            int[] haystack = { 0 };
            Predicate<int> match = x => x == 0;
            int count = 0;
            int index = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, match, count, index));
        }

        [Test]
        public void Search_ConditionSearch_IndexIsTooLarge()
        {
            int[] haystack = { 0 };
            Predicate<int> match = x => x == 0;
            int count = 0;
            int index = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => narr.Search(haystack, match, count, index));
        }
    }
}
