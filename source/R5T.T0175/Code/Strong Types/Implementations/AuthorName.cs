using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0175
{
    /// <inheritdoc cref="IAuthorName"/>
    [StrongTypeImplementationMarker]
    public class AuthorName : TypedBase<string>, IStrongTypeMarker,
        IAuthorName
    {
        public AuthorName(string value)
            : base(value)
        {
        }
    }
}
