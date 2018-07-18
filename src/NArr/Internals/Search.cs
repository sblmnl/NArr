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
        /// <returns>System.Int32[]</returns>
        public static int[] Call(byte[] haystack, byte[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(sbyte[] haystack, sbyte[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(bool[] haystack, bool[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(char[] haystack, char[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(short[] haystack, short[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(ushort[] haystack, ushort[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(int[] haystack, int[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(uint[] haystack, uint[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(long[] haystack, long[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(ulong[] haystack, ulong[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(float[] haystack, float[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(double[] haystack, double[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(decimal[] haystack, decimal[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call(string[] haystack, string[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (haystack[i] == needle[0]
                        && haystack[last] == needle[needle.Length - 1])
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
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="needle">The collection to find.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call<T>(T[] haystack, T[] needle, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (needle.Length == 0 || needle == null) throw new ArgumentNullException($"The length of '{nameof(needle)}' cannot be 0.");
            if (needle.Length > haystack.Length) throw new ArgumentException($"The length of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            Func<T, T, bool> compare = (x, y) => x.GetHashCode() == y.GetHashCode();
            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                int last = i + (needle.Length - 1);

                if (last < haystack.Length)
                {
                    if (compare(haystack[i], needle[0])
                        && compare(haystack[last], needle[needle.Length - 1]))
                    {
                        bool match = true;

                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (compare(haystack[i + j], needle[j]))
                            {
                                match = false;
                                break;
                            }
                        }

                        if (match)
                        {
                            results[size] = i;
                            if (results.Length == count && count != 0) break;
                            i += needle.Length - 1;
                            size++;
                            if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }

        /// <summary>
        /// Finds all occurrence indexes of elements matching the specified predicate condition(s) in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The predicate for the elements to match.</param>
        /// <param name="count">The number of elements to find, 0 for all.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32[]</returns>
        public static int[] Call<T>(T[] haystack, Predicate<T> match, int count = 0, int index = 0)
        {
            if (haystack.Length == 0 || haystack == null) throw new ArgumentNullException($"The length of '{nameof(haystack)}' cannot be 0.");
            if (count < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be less than 0.");
            if (count > haystack.Length) throw new ArgumentOutOfRangeException($"The value of '{nameof(count)}' cannot be greater than {haystack.Length}");
            if (index < 0) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be less than 0.");
            if (index > haystack.Length - 1) throw new ArgumentOutOfRangeException($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.");

            int[] results = new int[100];
            int size = 0;

            for (int i = index; i < haystack.Length; i++)
            {
                if (match(haystack[i]))
                {
                    results[size] = i;
                    if (results.Length == count && count != 0) break;
                    size++;
                    if (size > results.Length) global::NArr.Internals.Resize.Call(ref results, size + 100);
                }
            }

            global::NArr.Internals.Resize.Call(ref results, size);
            return results;
        }
    }
}
