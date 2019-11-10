namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class FragmentBenchmarks
    {
        [Benchmark]
        public byte[][] FewSmallFragments()
        {
            return NArr.Fragment(new byte[100], 5);
        }

        [Benchmark]
        public byte[][] ManySmallFragments()
        {
            return NArr.Fragment(new byte[100000], 5);
        }

        [Benchmark]
        public byte[][] FewLargeFragments()
        {
            return NArr.Fragment(new byte[100000], 5000);
        }

        [Benchmark]
        public byte[][] ManyLargeFragments()
        {
            return NArr.Fragment(new byte[100000000], 5000);
        }
    }
}
