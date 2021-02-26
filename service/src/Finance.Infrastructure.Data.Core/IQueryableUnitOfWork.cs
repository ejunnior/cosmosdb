namespace Finance.Infrastructure.Data.Core
{
    using Domain.Core;
    using Microsoft.Azure.Cosmos;

    public interface IQueryableUnitOfWork
          : IUnitOfWork
    {
        CosmosClient CreateSet();
    }
}