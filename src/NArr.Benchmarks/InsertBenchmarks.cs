namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class InsertBenchmarks
    {
        [Benchmark]
        public byte[] SmallCollectionIntoEmptyArray()
        {
            byte[] array = new byte[0];
            byte[] collection = new byte[100];

            NArr.Insert(ref array, collection, 0);

            return array;
        }

        [Benchmark]
        public byte[] LargeCollectionIntoEmptyArray()
        {
            byte[] array = new byte[0];
            byte[] collection = new byte[100];

            NArr.Insert(ref array, collection, 0);

            return array;
        }

        [Benchmark]
        public byte[] SmallCollectionIntoSmallArray()
        {
            byte[] array = new byte[100];
            byte[] collection = new byte[100];

            NArr.Insert(ref array, collection, 49);

            return array;
        }

        [Benchmark]
        public byte[] LargeCollectionIntoLargeArray()
        {
            byte[] array = new byte[100000];
            byte[] collection = new byte[100000];

            NArr.Insert(ref array, collection, 49999);

            return array;
        }
    }
}
