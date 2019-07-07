namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ShiftTests
    {
        [Test]
        public void Shift_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int count = 3;

            int[] expected = { 5, 6, 7, 0, 1, 2, 3, 4 };
            NArr.Shift(ref array, count);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Shift_EmptyArray()
        {
            int[] array = { };
            int count = 1;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Shift(ref array, count));
        }

        [Test]
        public void Shift_CountIsTooSmall()
        {
            int[] array = { 0, 0 };
            int count = -3;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Shift(ref array, count));
        }

        [Test]
        public void Shift_CountIsTooLarge()
        {
            int[] array = { 0, 0 };
            int count = 3;

            Assert.Throws<ArgumentOutOfRangeException>(() => NArr.Shift(ref array, count));
        }
    }
}
