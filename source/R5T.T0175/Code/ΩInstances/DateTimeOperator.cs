using System;


namespace R5T.T0175
{
    public class DateTimeOperator : IDateTimeOperator
    {
        #region Infrastructure

        public static IDateTimeOperator Instance { get; } = new DateTimeOperator();


        private DateTimeOperator()
        {
        }

        #endregion
    }
}
