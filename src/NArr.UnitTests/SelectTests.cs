namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SelectTests
    {
        [Test]
        public void Select_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 3;
            int to = 5;

            int[] expected = { 3, 4, 5 };
            int[] actual = array.Select(from, to);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Select_IsExpected_Inverse()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 5;
            int to = 3;

            int[] expected = { 5, 4, 3 };
            int[] actual = array.Select(from, to);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Select_FromIndexIsTooLarge()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 8;
            int to = 3;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Select(from, to));
        }

        [Test]
        public void Select_FromIndexIsTooSmall()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = -1;
            int to = 3;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Select(from, to));
        }

        [Test]
        public void Select_ToIndexIsTooLarge()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 5;
            int to = 8;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Select(from, to));
        }

        [Test]
        public void Select_ToIndexIsTooSmall()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 5;
            int to = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Select(from, to));
        }
    }
}
