using System;

using R5T.T0151;


namespace R5T.T0175
{
    public class FileName : TypedString, IFileName
    {
        public FileName(string value)
            : base(value)
        {
        }
    }
}
