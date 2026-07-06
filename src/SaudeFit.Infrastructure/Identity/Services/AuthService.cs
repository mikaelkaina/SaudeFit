using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SaudeFit.Infrastructure.Identity.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SaudeFit.Infrastructure.Identity.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly JwtSettings _jwtSettings;

    public AuthService(UserManager<ApplicationUser> userManager, IOptions<JwtSettings> jwtOptions)
    {
        _userManager = userManager;
        _jwtSettings = jwtOptions.Value;
    }

    public async Task<bool> RegisterAsync(AuthRequest request)
    {
        var user = new ApplicationUser { UserName = request.Email, Email = request.Email };
        var result = await _userManager.CreateAsync(user, request.Password);
        return result.Succeeded;
    }

    public async Task<AuthResponse?> LoginAsync(AuthRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
            return null;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.UTF8.GetBytes(_jwtSettings.Key);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName!)
            }),
            Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiresInMinutes),
            Issuer = _jwtSettings.Issuer,
            Audience = _jwtSettings.Audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return new AuthResponse(tokenHandler.WriteToken(token), tokenDescriptor.Expires!.Value);
    }
}

