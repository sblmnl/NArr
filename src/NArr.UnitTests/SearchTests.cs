namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SearchTests
    {
        [Test]
        public void Search_TypeSearch_IsExpected()
        {
            int[] haystack = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] needle = { 3 };

            int[] expected = { 3 };
            int[] actual = haystack.Search(needle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_ConditionSearch_IsExpected()
        {
            int[] haystack = { 0, 1, 2, 3, 3, 4, 5, 6, 7 };
            Func<int, bool> match = x => x == 3;

            int[] expected = { 3, 4 };
            int[] actual = haystack.Search(match);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_TypeSearch_EmptyNeedle()
        {
            int[] haystack = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] needle = { };

            int[] expected = { };
            int[] actual = haystack.Search(needle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_TypeSearch_NeedleIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0, 0 };

            int[] expected = { };
            int[] actual = haystack.Search(needle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Search_TypeSearch_CountIsTooSmall()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(needle, count));
        }

        [Test]
        public void Search_TypeSearch_CountIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 2;

            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(needle, count));
        }

        [Test]
        public void Search_TypeSearch_IndexIsTooSmall()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 0;
            int index = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(needle, count, index));
        }

        [Test]
        public void Search_TypeSearch_IndexIsTooLarge()
        {
            int[] haystack = { 0 };
            int[] needle = { 0 };
            int count = 0;
            int index = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(needle, count, index));
        }

        [Test]
        public void Search_ConditionSearch_CountIsTooSmall()
        {
            int[] haystack = { 0 };
            Func<int, bool> match = x => x == 0;
            int count = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(match, count));
        }

        [Test]
        public void Search_ConditionSearch_CountIsTooLarge()
        {
            int[] haystack = { 0 };
            Func<int, bool> match = x => x == 0;
            int count = 2;
            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(match, count));
        }

        [Test]
        public void Search_ConditionSearch_IndexIsTooSmall()
        {
            int[] haystack = { 0 };
            Func<int, bool> match = x => x == 0;
            int count = 0;
            int index = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(match, count, index));
        }

        [Test]
        public void Search_ConditionSearch_IndexIsTooLarge()
        {
            int[] haystack = { 0 };
            Func<int, bool> match = x => x == 0;
            int count = 0;
            int index = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => haystack.Search(match, count, index));
        }
    }
}
