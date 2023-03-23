using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0175
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class DirectoryName : TypedString, IStrongTypeMarker, IDirectoryName
    {
        public DirectoryName(string value)
            : base(value)
        {
        }
    }
}
