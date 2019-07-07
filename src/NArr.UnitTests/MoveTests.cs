namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class MoveTests
    {
        [Test]
        public void Move_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 1;
            int count = 2;
            int to = 5;

            int[] expected = { 0, 3, 4, 5, 6, 1, 2, 7 };
            NArr.Move(ref array, from, count, to);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Move_NullArray()
        {
            int[] array = null;
            int from = 0;
            int count = 1;
            int to = 1;

            Assert.Throws<ArgumentNullException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_EmptyArray()
        {
            int[] array = { };
            int from = 0;
            int count = 1;
            int to = 1;

            Assert.Throws<ArgumentException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_FromIndexIsTooLarge()
        {
            int[] array = { 0, 1 };
            int from = 2;
            int count = 1;
            int to = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_FromIndexIsTooSmall()
        {
            int[] array = { 0, 1 };
            int from = -1;
            int count = 1;
            int to = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_ToIndexIsTooLarge()
        {
            int[] array = { 0, 1 };
            int from = 0;
            int count = 1;
            int to = 2;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_ToIndexIsTooSmall()
        {
            int[] array = { 0, 1 };
            int from = 0;
            int count = 1;
            int to = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_CountIsTooLarge()
        {
            int[] array = { 0, 1 };
            int from = 0;
            int count = 3;
            int to = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_CountIsTooSmall()
        {
            int[] array = { 0, 1 };
            int from = 0;
            int count = -1;
            int to = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Move(ref array, from, count, to));
        }

        [Test]
        public void Move_FromEqualsTo()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 1;
            int count = 2;
            int to = 1;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };
            NArr.Move(ref array, from, count, to);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Move_CountEqualsZero()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int from = 1;
            int count = 0;
            int to = 5;

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };
            NArr.Move(ref array, from, count, to);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Move_ArrayLengthEqualsOne()
        {
            int[] array = { 0 };
            int from = 0;
            int count = 1;
            int to = 0;

            int[] expected = { 0 };
            NArr.Move(ref array, from, count, to);

            Assert.AreEqual(expected, array);
        }
    }
}
