using System;

using R5T.T0132;


namespace R5T.T0186.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IOwnerName ToOwnerName(string value)
        {
            var output = new OwnerName(value);
            return output;
        }

        public IRepositoryName ToRepositoryName(string value)
        {
            var output = new RepositoryName(value);
            return output;
        }
    }
}
