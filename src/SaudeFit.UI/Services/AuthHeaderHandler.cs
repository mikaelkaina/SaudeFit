using Microsoft.JSInterop;
using System.Net.Http.Headers;

namespace SaudeFit.UI.Services;

public class AuthHeaderHandler : DelegatingHandler
{
    private readonly AuthStateProvider _authStateProvider;

    public AuthHeaderHandler(AuthStateProvider authStateProvider)
    {
        _authStateProvider = authStateProvider;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _authStateProvider.GetTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}