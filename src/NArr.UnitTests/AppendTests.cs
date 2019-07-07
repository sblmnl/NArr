namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AppendTests
    {
        [Test]
        public void Append_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5 };
            int[] collection = { 6, 7 };

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };
            NArr.Append(ref array, collection);

            Assert.AreEqual(expected, array);
        }

        [Test]
        public void Append_NullArray()
        {
            int[] array = null;
            int[] collection = { 6, 7 };

            Assert.Throws<ArgumentNullException>(() => NArr.Append(ref array, collection));
        }

        [Test]
        public void Append_NullCollection()
        {
            int[] array = { 0, 1, 2, 3, 4, 5 };
            int[] collection = null;

            Assert.Throws<ArgumentNullException>(() => NArr.Append(ref array, collection));
        }
    }
}
