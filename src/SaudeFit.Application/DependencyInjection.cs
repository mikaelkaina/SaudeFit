using Microsoft.Extensions.DependencyInjection;
using SaudeFit.Application.Features.Food.Queries.GetByCategory;
using SaudeFit.Application.Features.Food.Queries.GetFood;

namespace SaudeFit.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetFoodByCategory, GetFoodByCategory>();
        services.AddScoped<GetFood>();
        
        return services;
    }
}