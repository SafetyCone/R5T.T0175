using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.T0175
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class DirectoryPath : TypedString, IStrongTypeMarker, IDirectoryPath
    {
        public DirectoryPath(string value)
            : base(value)
        {
        }
    }
}
