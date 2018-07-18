namespace NArr.Internals
{
    using System;

    internal static class Next
    {
        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(byte[] haystack, byte[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(sbyte[] haystack, sbyte[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(bool[] haystack, bool[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(char[] haystack, char[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(short[] haystack, short[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(ushort[] haystack, ushort[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(int[] haystack, int[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(uint[] haystack, uint[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(long[] haystack, long[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(ulong[] haystack, ulong[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(float[] haystack, float[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(double[] haystack, double[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(decimal[] haystack, decimal[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call(string[] haystack, string[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds the next occurrence index of a collection in an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The collection to find.</param>
        /// <param name="needle">The array to search.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call<T>(T[] haystack, T[] needle, int index)
        {
            if (haystack.Length == 0) throw new Exception($"The value of '{nameof(haystack)}' cannot be null.", new ArgumentNullException());
            if (needle.Length == 0) throw new Exception($"The value of '{nameof(needle)}' cannot be null.", new ArgumentNullException());
            if (needle.Length > haystack.Length) throw new Exception($"The size of '{nameof(needle)}' cannot be larger than that of '{nameof(haystack)}'.", new ArgumentOutOfRangeException());
            if (index > haystack.Length - 1) throw new Exception($"The value of '{nameof(index)}' cannot be greater than {haystack.Length - 1}.", new ArgumentOutOfRangeException());
            if (index < 0) throw new Exception($"The value of '{nameof(index)}' cannot be less than 0.", new ArgumentOutOfRangeException());

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

                    if (match) return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Finds next occurence index of an element in an array that matches the conditions of a predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="haystack">The array to search.</param>
        /// <param name="match">The conditions for an element to match.</param>
        /// <param name="index">The index to begin searching from.</param>
        /// <returns>System.Int32</returns>
        public static int Call<T>(T[] haystack, Predicate<T> match, int index)
        {
            if (haystack.Length == 0) return -1;
            for (int i = index; i < haystack.Length; i++) if (match(haystack[i])) return i;
            return -1;
        }
    }
}
