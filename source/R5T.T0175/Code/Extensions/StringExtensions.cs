using System;


namespace R5T.T0175.Extensions
{
    public static class StringExtensions
    {
        public static ApplicationName ToApplicationName(this string value)
        {
            return Instances.StringOperator.ToApplicationName(value);
        }

        public static DirectoryName ToDirectoryName(this string value)
        {
            return Instances.StringOperator.ToDirectoryName(value);
        }

        public static DirectoryPath ToDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToDirectoryPath(value);
        }

        public static FileName ToFileName(this string value)
        {
            return Instances.StringOperator.ToFileName(value);
        }
    }
}
