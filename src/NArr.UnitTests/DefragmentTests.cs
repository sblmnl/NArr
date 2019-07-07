namespace UnitTests
{
    using NArr;
    using NUnit.Framework;
    using System;

    [TestFixture]
    class DefragmentTests
    {

        [Test]
        public void Defragment_IsExpected()
        {
            int[][] fragments = {
                new int[256],
                new int[256],
                new int[1]
            };

            int[] actual = fragments.Defragment();
            int[] expected = new int[513];

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Defragment_NullArray()
        {
            int[][] fragments = null;

            Assert.Throws<ArgumentNullException>(() => fragments.Defragment());
        }
    }
}
