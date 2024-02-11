namespace MassTransit.EntityFrameworkCoreIntegration.Saga
{
    using System.Threading.Tasks;
    using EntityFrameworkCoreIntegration;
    using Microsoft.EntityFrameworkCore;


    public class ContainerSagaDbContextFactory<TSaga> :
        ISagaDbContextFactory<TSaga>
        where TSaga : class, ISaga
    {
        readonly DbContext _dbContext;

        public ContainerSagaDbContextFactory(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbContext Create()
        {
            return _dbContext;
        }

        public DbContext CreateScoped<T>(ConsumeContext<T> context)
            where T : class
        {
            return _dbContext;
        }

        public ValueTask ReleaseAsync(DbContext dbContext)
        {
            return default;
        }
    }
}
