using Microsoft.EntityFrameworkCore;
using VM_Server.Interfaces;
using VM_Server.Repositories;

namespace VM_Server.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigurePostgreSql(this IServiceCollection serv, IConfiguration conf) => serv.AddDbContext<RepositoryContext>(opt =>
        {
            opt.UseNpgsql(conf.GetConnectionString("localvm"));
        });
        public static void ConfigureRepositoryManager(this IServiceCollection serv) => serv.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
