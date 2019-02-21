namespace UnitTests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    class FragmentTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Fragment_IsExpected()
        {
            int[] array = new int[513];
            int size = 256;

            int[][] actual = narr.Fragment(array, size);
            int[][] expected = {
                new int[256],
                new int[256],
                new int[1]
            };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Fragment_SizeIsTooSmall()
        {
            int[] array = new int[8];
            int size = 0;

            Assert.Throws<ArgumentException>(() => narr.Fragment(array, size));
        }
    }
}
