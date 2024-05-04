using System;

namespace DateTimeEqualityExtensions
{
    public static class DateTimeEqualityExtensions
    {
        public static bool IsGreater(this DateTime? dt1, DateTime? dt2)
        {
            return Nullable.Compare(dt1, dt2) > 0;
        }

        public static bool IsGreaterOrEqual(this DateTime? dt1, DateTime? dt2)
        {
            return Nullable.Compare(dt1, dt2) >= 0;
        }

        public static bool IsLess(this DateTime? dt1, DateTime? dt2)
        {
            return Nullable.Compare(dt1, dt2) < 0;
        }

        public static bool IsLessOrEqual(this DateTime? dt1, DateTime? dt2)
        {
            return Nullable.Compare(dt1, dt2) <= 0;
        }
    }
}