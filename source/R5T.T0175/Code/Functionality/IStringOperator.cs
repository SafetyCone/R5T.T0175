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

        public AuthorName ToAuthorName(string value)
        {
            var output = new AuthorName(value);
            return output;
        }
    }
}
