namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class SearchBenchmarks
    {
        public const int N = 100000000;

        [Benchmark]
        public int[] NoOccurrences()
        {
            byte[] haystack = new byte[N];
            byte[] needle = { 1, 1, 0, 1 };

            return haystack.Search(needle);
        }

        [Benchmark]
        public int[] SingleOccurrence()
        {
            byte[] haystack = new byte[N];
            byte[] needle = { 1, 1, 0, 1 };

            haystack[50000000] = 1;
            haystack[50000001] = 1;
            haystack[50000003] = 1;

            return haystack.Search(needle, count: 1, index: 0);
        }

        [Benchmark]
        public int[] SingleOccurrenceWithNearMatches()
        {
            byte[] haystack = new byte[N];
            byte[] needle = { 1, 1, 0, 1 };

            haystack[20000000] = 1;
            haystack[20000001] = 1;
            haystack[20000002] = 1;
            haystack[20000003] = 1;

            haystack[40000000] = 1;
            haystack[40000001] = 1;
            haystack[40000002] = 1;
            haystack[40000003] = 1;

            haystack[50000000] = 1;
            haystack[50000001] = 1;
            haystack[50000003] = 1;

            return haystack.Search(needle, count: 1, index: 0);
        }

        [Benchmark]
        public int[] MultipleOccurrences()
        {
            byte[] haystack = new byte[N];
            byte[] needle = { 1, 1, 0, 1 };

            haystack[30000000] = 1;
            haystack[30000001] = 1;
            haystack[30000003] = 1;

            haystack[50000000] = 1;
            haystack[50000001] = 1;
            haystack[50000003] = 1;

            return haystack.Search(needle);
        }

        [Benchmark]
        public int[] MultipleOccurrencesWithNearMatches()
        {
            byte[] haystack = new byte[N];
            byte[] needle = { 1, 1, 0, 1 };

            haystack[20000000] = 1;
            haystack[20000001] = 1;
            haystack[20000002] = 1;
            haystack[20000003] = 1;

            haystack[30000000] = 1;
            haystack[30000001] = 1;
            haystack[30000003] = 1;

            haystack[40000000] = 1;
            haystack[40000001] = 1;
            haystack[40000002] = 1;
            haystack[40000003] = 1;

            haystack[50000000] = 1;
            haystack[50000001] = 1;
            haystack[50000003] = 1;

            return haystack.Search(needle);
        }
    }
}
