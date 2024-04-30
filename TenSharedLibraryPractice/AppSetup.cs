using Ten.Shared.AI.Application.EvilAiStack.Extensions;
using Ten.Shared.AI.Application.EvilAiStack.Secrets;
using Ten.Shared.Health;
using Ten.Shared.Hosting.AspNetCore.Builder;
using Ten.Shared.Secrets;

namespace TenSharedLibraryPractice
{
    public static class AppSetup
    {
        public static void Configure(TenWebAppBuilder builder)
        {
            builder.AddTenHealthChecks();

            var services = builder.Services;
            var configuration = builder.Configuration;

            services.AddSecretsVault<EvilAiAppSecretsCache>(configuration);
            services.AddEvilAiAppServices(configuration);

            services.AddLogging();

            services.AddControllers();
        }
    }
}
