using SBIChallenge.Services;
using SBIChallenge.Services.Implementation;

using Microsoft.Extensions.DependencyInjection;

namespace SBIChallenge.Utils
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IApiHelper, ApiHelper>();
            services.AddScoped<IPostsService, PostsService>();
        }
    }
}