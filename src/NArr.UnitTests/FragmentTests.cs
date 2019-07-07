namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class FragmentTests
    {
        [Test]
        public void Fragment_IsExpected()
        {
            int[] array = new int[513];
            int size = 256;

            int[][] actual = array.Fragment(size);
            int[][] expected = {
                new int[256],
                new int[256],
                new int[1]
            };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fragment_NullArray()
        {
            int[] array = null;
            int size = 256;

            Assert.Throws<ArgumentNullException>(() => array.Fragment(size));
        }

        [Test]
        public void Fragment_SizeTooLarge()
        {
            int[] array = new int[10];
            int size = 11;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Fragment(size));
        }

        [Test]
        public void Fragment_SizeTooSmall()
        {
            int[] array = new int[10];
            int size = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => array.Fragment(size));
        }
    }
}
