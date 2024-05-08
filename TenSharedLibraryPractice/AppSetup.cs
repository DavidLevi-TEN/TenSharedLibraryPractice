using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Ten.Shared.AI.Application.EvilAiStack.Extensions;
using Ten.Shared.AI.Application.EvilAiStack.Secrets;
using Ten.Shared.Audit;
using Ten.Shared.Health;
using Ten.Shared.Hosting.AspNetCore.Builder;
using Ten.Shared.Logging.AspNetCore;
using Ten.Shared.Secrets;
using TenMaid.Shared.AspNetCore.Audit;

namespace TenSharedLibraryPractice
{
    public static class AppSetup
    {
        public static void Configure(TenWebAppBuilder builder)
        {
            builder.AddTenHealthChecks();

            var services = builder.Services;
            var configuration = builder.Configuration;

            builder.AddTenLogging();

            services.AddSecretsVault<EvilAiAppSecretsCache>(configuration);
            services.AddEvilAiAppServices(configuration);

            services.AddGrpc();

            services.AddControllers();
        }
    }
}
