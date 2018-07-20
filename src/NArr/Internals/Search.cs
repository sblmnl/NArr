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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1])
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (haystack[i] == needle[0]                        // filter most possible non-matches
                        && haystack[last] == needle[needle.Length - 1]) 
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (haystack[i + j] != needle[j])           // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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
            int[] results = new int[100];                               // store the result indexes
            int size = 0;                                               // keep track of the true size of the results array
            int last;                                                   // store the current index in the haystack of the last element in the needle
            bool match = true;                                          // keep track of whether or not a chunk is a match or not

            for (int i = index; i < haystack.Length; i++)               // loop through the haystack starting at the specified index
            {
                last = i + (needle.Length - 1);                         // calculate the current index in the haystack of the last element in the needle

                if (last < haystack.Length)                             // verify that a needle will fit between the current index and the end of the haystack
                {
                    if (compare(haystack[i], needle[0])                 // filter most possible non-matches
                        && compare(haystack[last], needle[needle.Length - 1])) 
                    {
                        for (int j = 0; j < needle.Length; j++)         // loop through the needle
                        {
                            if (compare(haystack[i + j], needle[j]))    // verify that the current haystack element matches the corresponding element in the needle
                            {
                                match = false;
                                break;                                  // if not a match then break and move to next iteration
                            }
                        }

                        if (match)
                        {
                            results[size] = i;                                                  // add result index to the results array
                            if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                            i += needle.Length - 1;                                             // set i to the index after the needle for the next iteration
                            size++;                                                             // add 1 to the true size to accomodate for a new match 
                            if (size > results.Length)
                                global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                        }
                    }
                }
                else break;
            }

            global::NArr.Internals.Resize.Call(ref results, size);    // resize the results array to the true size
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

            int[] results = new int[100];                           // store the result indexes
            int size = 0;                                           // keep track of the true size of the results array

            for (int i = index; i < haystack.Length; i++)                               // loop through the haystack starting at the specified index
            {
                if (match(haystack[i]))                                                 // verify that the current haystack element matches the specified condition(s)
                {
                    results[size] = i;                                                  // add result index to the results array
                    if (results.Length == count && count != 0) break;                   // if results array length is equal to the specified count and count is not 0 then break and return results
                    size++;                                                             // add 1 to the true size to accomodate for a new match 
                    if (size > results.Length)
                        global::NArr.Internals.Resize.Call(ref results, size + 100);    // MEMORY OPTIMIZATION: increase results array capacity by 100 elements if the true size is greater than the results array length
                }
            }

            global::NArr.Internals.Resize.Call(ref results, size);  // resize the results array to the true size
            return results;
        }
    }
}
