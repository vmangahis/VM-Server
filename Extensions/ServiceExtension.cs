using Microsoft.EntityFrameworkCore;
using VM_Server.Interfaces;
using VM_Server.Repositories;

namespace VM_Server.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureSqlServer(this IServiceCollection serv) => 
            serv.AddDbContext<RepositoryContext>(opt => opt.UseNpgsql(Environment.GetEnvironmentVariable("LOCALVM")));

        public static void ConfigureRepositoryManager(this IServiceCollection serv) => serv.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureCors(this IServiceCollection serv) => serv.AddCors();
    }
}
