using System;


namespace R5T.T0186.Extensions
{
    public static class StringExtensions
    {
        public static IOwnerName ToOwnerName(this string value)
        {
            return Instances.StringOperator_Extensions.ToOwnerName(value);
        }

        public static IRepositoryName ToRepositoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryName(value);
        }

        public static IOwnerName ToGitHubRepositoryOwnerName(this string value)
        {
            return Instances.StringOperator_Extensions.ToOwnerName(value);
        }

        public static IRepositoryName ToGitHubRepositoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryName(value);
        }
    }
}
