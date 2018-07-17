namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ShiftTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Shift_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int count = 3;

            int[] expected = { 5, 6, 7, 0, 1, 2, 3, 4 };
            narr.Shift(ref array, count);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Shift_EmptyArray()
        {
            int[] array = { };
            int count = 0;

            Assert.Throws<Exception>(() => narr.Shift(ref array, count));
        }

        [Test]
        public void Shift_CountIsTooSmall()
        {
            int[] array = { 0, 0 };
            int count = -3;

            Assert.Throws<Exception>(() => narr.Shift(ref array, count));
        }

        [Test]
        public void Shift_CountIsTooLarge()
        {
            int[] array = { 0, 0 };
            int count = 3;

            Assert.Throws<Exception>(() => narr.Shift(ref array, count));
        }
    }
}
