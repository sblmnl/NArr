namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class AppendBenchmarks
    {
        [Benchmark]
        public void AppendSingleElement()
        {
            byte[] array = new byte[0];
            byte[] collection = new byte[1];

            NArr.Append(ref array, collection);
        }

        [Benchmark]
        public void AppendLargeCollection()
        {
            byte[] array = new byte[0];
            byte[] collection = new byte[100000000];

            NArr.Append(ref array, collection);
        }
    }
}
