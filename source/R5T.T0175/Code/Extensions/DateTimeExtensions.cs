using System;


namespace R5T.T0175.Extensions
{
    public static class DateTimeExtensions
    {
        public static Timestamp ToTimestamp(this DateTime value)
        {
            return Instances.DateTimeOperator.ToTimestamp(value);
        }
    }
}
