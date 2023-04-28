using System;

using R5T.T0178;


namespace R5T.T0186
{
    /// <summary>
    /// <inheritdoc cref="IGitHubRepositoryOwnerName" path="/summary"/>
    /// <para>
    /// Quality-of-life name overload for <see cref="IGitHubRepositoryOwnerName"/>.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IOwnerName : IStrongTypeMarker,
        IGitHubRepositoryOwnerName
    {
    }
}
