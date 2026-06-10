using Microsoft.Extensions.DependencyInjection;
using SaudeFit.Application.Features.Foods.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetByCategory;

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