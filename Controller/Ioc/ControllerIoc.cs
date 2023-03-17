namespace Repository.Ioc
{
    public static class ControllerIoc
    {
        public static IServiceCollection ConfigureController(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
