using Microsoft.Extensions.DependencyInjection;
using SaudeFit.Application.Features.Exercises.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetByCategory;

namespace SaudeFit.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetFoodByCategoryHandler, GetFoodByCategoryHandler>();
        services.AddScoped<IGetAllFoodHandler, GetAllFoodHandler>();

        services.AddScoped<IGetAllExerciseHandler, GetAllExerciseHandler>();
        return services;
    }
}