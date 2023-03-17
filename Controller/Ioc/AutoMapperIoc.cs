using Controller.Mapping;

namespace Repository.Ioc
{
    public static class AutoMapperIoc
    {
        public static IServiceCollection ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapping));

            return services;
        }
    }
}
