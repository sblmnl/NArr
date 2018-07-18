namespace NArr.Internals
{
    using System;

    internal static class Find
    {
        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(byte[] haystack, byte[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(sbyte[] haystack, sbyte[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(bool[] haystack, bool[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(char[] haystack, char[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(short[] haystack, short[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(ushort[] haystack, ushort[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(int[] haystack, int[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(uint[] haystack, uint[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(long[] haystack, long[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(ulong[] haystack, ulong[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(float[] haystack, float[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(double[] haystack, double[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(decimal[] haystack, decimal[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(string[] haystack, string[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0]
                    && haystack[i + ((needle.Length - 1) / 2)] == needle[(needle.Length - 1) / 2]
                    && haystack[i + (needle.Length - 1)] == needle[needle.Length - 1])
                {
                    bool match = true;

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
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call<T>(T[] haystack, T[] needle)
        {
            if (haystack.Length == 0) throw new Exception($"The length of '{nameof(haystack)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The length of '{nameof(needle)}' cannot be 0.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());

            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (Equals(haystack[i], needle[0])
                    && Equals(haystack[i + ((needle.Length - 1) / 2)], needle[(needle.Length - 1) / 2])
                    && Equals(haystack[i + (needle.Length - 1)], needle[needle.Length - 1]))
                {
                    bool match = true;

                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (!Equals(haystack[i + j], needle[j]))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        results[count] = i;
                        i += needle.Length - 1;
                        count++;
                    }
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The predicate for the elements to match.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call<T>(T[] haystack, Predicate<T> match)
        {
            int[] results = new int[haystack.Length];
            int count = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (match(haystack[i]))
                {
                    results[count] = i;
                    count++;
                }
            }

            global::NArr.Internals.Resize.Call(ref results, count);
            return results;
        }
    }
}
