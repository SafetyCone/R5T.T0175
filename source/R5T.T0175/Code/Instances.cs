using System;


namespace R5T.T0175
{
    public static class Instances
    {
        public static IDateTimeOperator DateTimeOperator => T0175.DateTimeOperator.Instance;
        public static IStringOperator StringOperator => T0175.StringOperator.Instance;
    }
}