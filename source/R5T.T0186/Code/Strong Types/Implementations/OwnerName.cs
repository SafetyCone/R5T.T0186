using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0186
{
    /// <inheritdoc cref="IOwnerName"/>
    [StrongTypeImplementationMarker]
    public class OwnerName : TypedBase<string>, IStrongTypeMarker,
        IOwnerName
    {
        public OwnerName(string value)
            : base(value)
        {
        }
    }
}
