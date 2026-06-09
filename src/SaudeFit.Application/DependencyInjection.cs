using Microsoft.Extensions.DependencyInjection;
using SaudeFit.Application.Features.Food.Queries.GetAllFood;
using SaudeFit.Application.Features.Food.Queries.GetByCategory;

namespace SaudeFit.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetFoodByCategory, GetFoodByCategory>();
        services.AddScoped<IGetAllFood, GetAllFoodHandler>();
        
        return services;
    }
}