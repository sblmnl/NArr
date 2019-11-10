namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class DefragmentBenchmarks
    {
        [Benchmark]
        public byte[] FewSmallFragments()
        {
            byte[][] fragments = new byte[10][];
            for (int i = 0; i < fragments.Length; i++)
            {
                fragments[i] = new byte[8];
            }

            return fragments.Defragment();
        }

        [Benchmark]
        public byte[] ManySmallFragments()
        {
            byte[][] fragments = new byte[100000][];
            for (int i = 0; i < fragments.Length; i++)
            {
                fragments[i] = new byte[8];
            }

            return fragments.Defragment();
        }

        [Benchmark]
        public byte[] FewLargeFragments()
        {
            byte[][] fragments = new byte[10][];
            for (int i = 0; i < fragments.Length; i++)
            {
                fragments[i] = new byte[100000];
            }

            return fragments.Defragment();
        }

        [Benchmark]
        public byte[] ManyLargeFragments()
        {
            byte[][] fragments = new byte[100000][];
            for (int i = 0; i < fragments.Length; i++)
            {
                fragments[i] = new byte[10000];
            }

            return fragments.Defragment();
        }
    }
}
