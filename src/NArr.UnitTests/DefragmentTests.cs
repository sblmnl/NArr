namespace UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    class DefragmentTests
    {
        private static readonly NArr.Framework narr = new NArr.Framework();

        [Test]
        public void Defragment_IsExpected()
        {
            int[][] fragments = {
                new int[256],
                new int[256],
                new int[1]
            };

            int[] actual = narr.Defragment(fragments);
            int[] expected = new int[513];

            Assert.AreEqual(expected, actual);
        }
    }
}
