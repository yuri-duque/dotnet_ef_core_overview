using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.Repositories;
using Repository.Repositories.Interfaces;

namespace Repository.Ioc
{
    public static class EFIoc
    {
        public static IServiceCollection ConfigureRepository(this IServiceCollection services)
        {
            services.AddDbContext<BaseContext>();

            #region DependenciInjection

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

            return services;
        }
    }
}
