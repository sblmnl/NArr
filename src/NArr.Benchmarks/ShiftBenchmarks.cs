namespace NArr.Benchmarks
{
    using BenchmarkDotNet.Attributes;

    public class ShiftBenchmarks
    {
        [Benchmark]
        public byte[] PositiveShiftOfSmallArray()
        {
            byte[] array = new byte[100];

            NArr.Shift(ref array, 1);

            return array;
        }

        [Benchmark]
        public byte[] NegativeShiftOfSmallArray()
        {
            byte[] array = new byte[100];

            NArr.Shift(ref array, -1);

            return array;
        }

        [Benchmark]
        public byte[] PositiveShiftOfLargeArray()
        {
            byte[] array = new byte[100000];

            NArr.Shift(ref array, 1);

            return array;
        }

        [Benchmark]
        public byte[] NegativeShiftOfLargeArray()
        {
            byte[] array = new byte[100000];

            NArr.Shift(ref array, -1);

            return array;
        }
    }
}
