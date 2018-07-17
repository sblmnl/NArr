namespace UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class AppendTests
    {
        private static readonly NArr.Framework NArr = new NArr.Framework();

        [Test]
        public void Append_IsExpected()
        {
            int[] array = { 0, 1, 2, 3, 4, 5 };
            int[] collection = { 6, 7 };

            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7 };
            NArr.Append(ref array, collection);

            Assert.AreEqual(expected, array);
        }
    }
}
