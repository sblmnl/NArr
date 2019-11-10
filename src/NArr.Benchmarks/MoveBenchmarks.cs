namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class MoveBenchmarks
    {
        [Benchmark]
        public byte[] SmallCollectionInSmallArray()
        {
            byte[] array = new byte[100];

            NArr.Move(ref array, 0, 50, 49);

            return array;
        }

        [Benchmark]
        public byte[] SmallCollectionInLargeArray()
        {
            byte[] array = new byte[100000];

            NArr.Move(ref array, 0, 50, 49999);

            return array;
        }

        [Benchmark]
        public byte[] LargeCollectionInSmallArray()
        {
            byte[] array = new byte[100000];

            NArr.Move(ref array, 0, 50000, 49999);

            return array;
        }
    }
}
