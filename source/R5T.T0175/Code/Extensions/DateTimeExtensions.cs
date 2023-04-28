using System;


namespace R5T.T0175.Extensions
{
    public static class DateTimeExtensions
    {
        public static ITimestamp ToTimestamp(this DateTime value)
        {
            return Instances.DateTimeOperator.ToTimestamp(value);
        }
    }
}
