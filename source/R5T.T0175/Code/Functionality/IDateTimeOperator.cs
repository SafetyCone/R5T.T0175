using System;

using R5T.T0132;


namespace R5T.T0175
{
    [FunctionalityMarker]
    public partial interface IDateTimeOperator : IFunctionalityMarker
    {
        public ITimestamp ToTimestamp(DateTime value)
        {
            var output = new Timestamp(value);
            return output;
        }
    }
}
