using System;


namespace R5T.T0186.Extensions
{
    public class RepositoryNameOperator : IRepositoryNameOperator
    {
        #region Infrastructure

        public static IRepositoryNameOperator Instance { get; } = new RepositoryNameOperator();


        private RepositoryNameOperator()
        {
        }

        #endregion
    }
}
