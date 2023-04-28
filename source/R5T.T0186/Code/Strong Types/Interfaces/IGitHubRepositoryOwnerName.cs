using System;

using R5T.T0178;


namespace R5T.T0186
{
    /// <summary>
    /// Strongly-types a string as the name of a GitHub repository owner.
    /// </summary>
    [StrongTypeMarker]
    public interface IGitHubRepositoryOwnerName : IStrongTypeMarker,
        T0184.IRepositoryOwnerName
    {
    }
}
