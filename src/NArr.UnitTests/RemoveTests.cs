namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RemoveTests
    {
        [Test]
        public void Remove_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int count = 7;
            int index = 1;

            int[] expected = { 0 };
            NArr.Remove(ref array, count, index);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Remove_EmptyArray()
        {
            int[] array = { };
            int count = 0;
            int index = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Remove(ref array, count, index));
        }

        [Test]
        public void Remove_CountIsTooSmall()
        {
            int[] array = { 0 };
            int count = -1;
            int index = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Remove(ref array, count, index));
        }

        [Test]
        public void Remove_CountIsTooLarge()
        {
            int[] array = { 0 };
            int count = 2;
            int index = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Remove(ref array, count, index));
        }

        [Test]
        public void Remove_IndexIsTooSmall()
        {
            int[] array = { 0 };
            int count = 1;
            int index = -1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Remove(ref array, count, index));
        }

        [Test]
        public void Remove_IndexIsTooLarge()
        {
            int[] array = { 0 };
            int count = 1;
            int index = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Remove(ref array, count, index));
        }
    }
}
