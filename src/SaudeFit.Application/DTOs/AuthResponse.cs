namespace SaudeFit.Application.DTOs;

public record AuthResponse(string Token, DateTime Expiration);