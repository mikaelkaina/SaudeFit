using Microsoft.Extensions.DependencyInjection;
using SaudeFit.Application.Features.Auth.Login;
using SaudeFit.Application.Features.Auth.Register;
using SaudeFit.Application.Features.Exercises.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetAll;
using SaudeFit.Application.Features.Foods.Queries.GetByCategory;
using SaudeFit.Application.Features.UserProfile.Commands.Create;
using SaudeFit.Application.Features.UserProfile.Commands.Update;
using SaudeFit.Application.Features.UserProfile.Queries.GetUserProfile;

namespace SaudeFit.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetFoodByCategoryHandler, GetFoodByCategoryHandler>();
        services.AddScoped<IGetAllFoodHandler, GetAllFoodHandler>();

        services.AddScoped<IGetAllExerciseHandler, GetAllExerciseHandler>();
        services.AddScoped<IGetFoodByCategoryHandler, GetFoodByCategoryHandler>();
        
        services.AddScoped<ICreateUserProfileHandler,  CreateUserProfileHandler>();
        services.AddScoped<IUpdateUserProfileHandler, UpdateUserProfileHandler>();
        services.AddScoped<IGetUserProfileHandler, GetUserProfileHandler>();

        services.AddScoped<ILoginCommandHandler, LoginCommandHandler>();
        services.AddScoped<IRegisterCommandHandler, RegisterCommandHandler>();

        return services;
    }
}