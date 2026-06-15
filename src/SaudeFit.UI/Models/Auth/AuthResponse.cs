namespace SaudeFit.UI.Models.Auth;

public class AuthResponse
{
    public string? Token { get; set; }
    public DateTime Expiration { get; set; }
}