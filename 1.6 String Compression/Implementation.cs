﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1._6_String_Compression
{
    public class Implementation
    {
        public static string CompressBetter(string str)
    {
        var size = CountCompression(str);

        if (size >= str.Length)
        {
            return str;
        }

        var sb = new StringBuilder();
        var last = str[0];
        var count = 1;

        for (var i = 1; i < str.Length; i++)
        {
            if (str[i] == last)
            {
                count++;
            }
            else
            {
                sb.Append(last);
                sb.Append(count);
                last = str[i];
                count = 1;
            }
        }
        sb.Append(last);
        sb.Append(count);

        return sb.ToString();
    }

        private static int CountCompression(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            var last = str[0];
            var size = 0;
            var count = 0;

            for (var i = 1; i < str.Length; i++)
            {
                if (str[i] == last)
                {
                    count++;
                }
                else
                {
                    last = str[i];
                    size += 1 + string.Format("{0}", count).Length;
                    count = 1;
                }
            }

            size += 1 + string.Format("{0}", count).Length;

            return size;
        }

    }
}
