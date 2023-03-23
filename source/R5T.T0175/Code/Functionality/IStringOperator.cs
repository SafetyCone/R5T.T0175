using System;

using R5T.T0132;


namespace R5T.T0175
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ApplicationName ToApplicationName(string value)
        {
            var output = new ApplicationName(value);
            return output;
        }

        public DirectoryName ToDirectoryName(string value)
        {
            var output = new DirectoryName(value);
            return output;
        }

        public DirectoryPath ToDirectoryPath(string value)
        {
            var output = new DirectoryPath(value);
            return output;
        }

        public FileName ToFileName(string value)
        {
            var output = new FileName(value);
            return output;
        }
    }
}
