namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class SelectBenchmarks
    {
        [Benchmark]
        public byte[] SmallCollectionFromArray()
        {
            byte[] array = new byte[100000];

            return array.Select(49999, 50009);
        }

        [Benchmark]
        public byte[] LargeCollectionFromArray()
        {
            byte[] array = new byte[100000];

            return array.Select(49999, 99999);
        }
    }
}
