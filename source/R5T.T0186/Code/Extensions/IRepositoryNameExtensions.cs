using System;


namespace R5T.T0186.Extensions
{
    public static class IRepositoryNameExtensions
    {
        public static IRepositoryName ToGitHubRepositoryName(this T0184.IRepositoryName repositoryName)
        {
            return Instances.RepositoryNameOperator_Extensions.ToGitHubRepositoryName(repositoryName);
        }
    }
}
