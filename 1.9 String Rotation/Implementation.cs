using System;
using System.Collections.Generic;
using System.Text;

namespace _1._9_String_Rotation
{
    public static class Implementation
    {

        public static bool IsSubstring(String big, String small)
        {
            return big.IndexOf(small) >= 0;
        }

        public static bool IsRotation(String s1, String s2)
        {
            var len = s1.Length;

            /* check that s1 and s2 are equal length and not empty */
            if (len == s2.Length && len > 0)
            {
                /* concatenate s1 and s1 within new buffer */
                var s1S1 = s1 + s1;
                return IsSubstring(s1S1, s2);
            }

            return false;
        }

    }
}
