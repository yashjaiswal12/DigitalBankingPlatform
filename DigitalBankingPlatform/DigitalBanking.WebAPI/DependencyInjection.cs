using DigitalBanking.Infrastructure;

namespace DigitalBanking.WebAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureApiDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInrastructureDI(configuration);
            return services;
        }
    }
}
