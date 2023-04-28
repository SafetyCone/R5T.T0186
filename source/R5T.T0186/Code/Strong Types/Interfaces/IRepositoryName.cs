using System;

using R5T.T0178;


namespace R5T.T0186
{
    /// <summary>
    /// <inheritdoc cref="IGitHubRepositoryName" path="/summary"/>
    /// <para>
    /// Quality-of-life name overload for <see cref="IGitHubRepositoryName"/>.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryName : IStrongTypeMarker,
        IGitHubRepositoryName
    {
    }
}
