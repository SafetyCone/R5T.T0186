using System;

using R5T.T0132;


namespace R5T.T0186.Extensions
{
    [FunctionalityMarker]
    public partial interface IRepositoryNameOperator : IFunctionalityMarker
    {
        public IRepositoryName ToGitHubRepositoryName(T0184.IRepositoryName repositoryName)
        {
            var output = repositoryName.Value.ToRepositoryName();
            return output;
        }
    }
}
