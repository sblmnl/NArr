namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class RemoveBenchmarks
    {
        [Benchmark]
        public byte[] SmallCollectionFromSmallArray()
        {
            byte[] array = new byte[100];

            NArr.Remove(ref array, 10, 0);

            return array;
        }

        [Benchmark]
        public byte[] SmallCollectionFromLargeArray()
        {
            byte[] array = new byte[100000];

            NArr.Remove(ref array, 10, 49999);

            return array;
        }

        [Benchmark]
        public byte[] LargeCollectionFromLargeArray()
        {
            byte[] array = new byte[100000];

            NArr.Remove(ref array, 50000, 49999);

            return array;
        }
    }
}
