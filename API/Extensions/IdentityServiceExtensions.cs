using Microsoft.AspNetCore.Identity;
using Persistence;

public static class IdentityServiceExtentions
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddIdentityCore<AppUser>( opt =>
        {
            opt.Password.RequireNonAlphanumeric = false;

        })
        .AddEntityFrameworkStores<DataContext>()
        .AddSignInManager<SignInManager<AppUser>>();
        
        services.AddAuthentication();
        services.AddScoped<TokenService>();

        return services;
    }
}