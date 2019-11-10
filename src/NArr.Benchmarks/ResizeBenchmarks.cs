namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ResizeBenchmarks
    {
        [Benchmark]
        public byte[] SmallArrayToLargerArray()
        {
            byte[] array = new byte[10];

            NArr.Resize(ref array, 100);

            return array;
        }

        [Benchmark]
        public byte[] LargerArrayToSmallerArray()
        {
            byte[] array = new byte[100];

            NArr.Resize(ref array, 10);

            return array;
        }

        [Benchmark]
        public byte[] SmallArrayToLargeArray()
        {
            byte[] array = new byte[10];

            NArr.Resize(ref array, 100000);

            return array;
        }

        [Benchmark]
        public byte[] LargeArrayToSmallArray()
        {
            byte[] array = new byte[100000];

            NArr.Resize(ref array, 10);

            return array;
        }
    }
}
