namespace NArr.Internals
{
    using System;

    internal static class Search
    {
        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(byte[] haystack, byte[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(sbyte[] haystack, sbyte[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(bool[] haystack, bool[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(char[] haystack, char[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(short[] haystack, short[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(ushort[] haystack, ushort[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(int[] haystack, int[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(uint[] haystack, uint[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(long[] haystack, long[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(ulong[] haystack, ulong[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(float[] haystack, float[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(double[] haystack, double[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(decimal[] haystack, decimal[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall(string[] haystack, string[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[hMiddle] == needle[nMiddle]
                        && haystack[hLast] == needle[nLast])
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall<T>(T[] haystack, T[] needle, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int szResults = 0;
            int nLast = needle.Length - 1;
            int nMiddle = nLast / 2;
            int hLast, hMiddle;
            bool match = true;

            for (int i = index; i < haystack.Length; i++)
            {
                hLast = i + nLast;
                hMiddle = i + nMiddle;

                if (hLast < haystack.Length)
                {
                    if (haystack[i].Equals(needle[0])
                        && haystack[hMiddle].Equals(needle[nMiddle])
                        && haystack[hLast].Equals(needle[nLast]))
                    {
                        match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (!haystack[i + j].Equals(needle[j]))
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[szResults] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            szResults++;
                            if (szResults > results.Length)
                                Resize.Call(ref results, (szResults - 1) + 100);
                        }
                    }
                }
                else break;
            }

            Resize.Call(ref results, szResults);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <exception cref="ArgumentNullException">haystack</exception>
        /// <exception cref="ArgumentNullException">needle</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        /// <returns><see cref="System.Int32[]"/></returns>
        public static int[] Call<T>(T[] haystack, T[] needle, int count = 0, int index = 0)
        {
            if (haystack == null)
            {
                throw new ArgumentNullException(nameof(haystack), "Argument value is null");
            }
            if (needle == null)
            {
                throw new ArgumentNullException(nameof(needle), "Argument value is null");
            }
            if (count < 0 || count > haystack.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Argument value is outside the bounds of the array");
            }
            if (index < 0 || index > haystack.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Argument value is outside the bounds of the array");
            }
            if (haystack.Length == 0 || needle.Length == 0 || needle.Length > haystack.Length)
            {
                return new int[] { };
            }

            int[] results;
            switch (haystack.GetType().ToString())
            {
                case "System.Byte[]":
                    results = SafeCall((byte[])(object)haystack, (byte[])(object)needle, count, index);
                    break;
                case "System.SByte[]":
                    results = SafeCall((sbyte[])(object)haystack, (sbyte[])(object)needle, count, index);
                    break;
                case "System.Boolean[]":
                    results = SafeCall((bool[])(object)haystack, (bool[])(object)needle, count, index);
                    break;
                case "System.Char[]":
                    results = SafeCall((char[])(object)haystack, (char[])(object)needle, count, index);
                    break;
                case "System.Int16[]":
                    results = SafeCall((short[])(object)haystack, (short[])(object)needle, count, index);
                    break;
                case "System.UInt16[]":
                    results = SafeCall((ushort[])(object)haystack, (ushort[])(object)needle, count, index);
                    break;
                case "System.Int32[]":
                    results = SafeCall((int[])(object)haystack, (int[])(object)needle, count, index);
                    break;
                case "System.UInt32[]":
                    results = SafeCall((uint[])(object)haystack, (uint[])(object)needle, count, index);
                    break;
                case "System.Int64[]":
                    results = SafeCall((long[])(object)haystack, (long[])(object)needle, count, index);
                    break;
                case "System.UInt64[]":
                    results = SafeCall((ulong[])(object)haystack, (ulong[])(object)needle, count, index);
                    break;
                case "System.Single[]":
                    results = SafeCall((float[])(object)haystack, (float[])(object)needle, count, index);
                    break;
                case "System.Double[]":
                    results = SafeCall((double[])(object)haystack, (double[])(object)needle, count, index);
                    break;
                case "System.Decimal[]":
                    results = SafeCall((decimal[])(object)haystack, (decimal[])(object)needle, count, index);
                    break;
                case "System.String[]":
                    results = SafeCall((string[])(object)haystack, (string[])(object)needle, count, index);
                    break;
                default:
                    results = Call(haystack, needle, count, index);
                    break;
            }

            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The expression for the elements to match.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns><see cref="System.Int32[]"/></returns>
        private static int[] SafeCall<T>(T[] haystack, Func<T, bool> match, int count = 0, int index = 0)
        {
            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                if (match(haystack[i]))
                {
                    results[size] = i;
                    if (results.Length == count && count != 0) break;
                    size++;
                    if (size > results.Length)
                        Resize.Call(ref results, size + 100);
                }
            }

            Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The expression for the elements to match.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <exception cref="ArgumentNullException">haystack</exception>
        /// <exception cref="ArgumentOutOfRangeException">count</exception>
        /// <exception cref="ArgumentOutOfRangeException">index</exception>
        /// <returns><see cref="System.Int32[]"/></returns>
        public static int[] Call<T>(T[] haystack, Func<T, bool> match, int count = 0, int index = 0)
        {
            if (haystack == null)
            {
                throw new ArgumentNullException(nameof(haystack), "Argument value is null");
            }
            if (count < 0 || count > haystack.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Argument value is outside the bounds of the array");
            }
            if (index < 0 || index > haystack.Length - 1)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Argument value is outside the bounds of the array");
            }
            if (haystack.Length == 0)
            {
                return new int[] { };
            }

            return SafeCall(haystack, match, count, index);
        }
    }
}
