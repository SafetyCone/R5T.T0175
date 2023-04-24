using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0175
{
    /// <inheritdoc cref="ITimestamp"/>
    [StrongTypeImplementationMarker]
    public class Timestamp : TypedBase<DateTime>, IStrongTypeMarker,
        ITimestamp
    {
        public Timestamp(DateTime value)
            : base(value)
        {
        }
    }
}
