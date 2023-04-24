using System;


namespace R5T.T0175.Extensions
{
    public static class StringExtensions
    {
        public static ApplicationName ToApplicationName(this string value)
        {
            return Instances.StringOperator.ToApplicationName(value);
        }

        public static AuthorName ToAuthorName(this string value)
        {
            return Instances.StringOperator.ToAuthorName(value);
        }
    }
}
