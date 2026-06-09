namespace SaudeFit.Infrastructure.Identity.DTOs;

public record AuthResponse(string Token, DateTime Expiration);