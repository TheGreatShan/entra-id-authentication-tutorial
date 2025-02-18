using System.Text.Json;

namespace entra_id_auth_tutorial.Utils;

internal record AppSettings(
    string Instance,
    string TenantId,
    string ClientId,
    string ClientSecret,
    string Scopes);

internal class AppSettingsReader
{
    internal AppSettings ReadAppSettings()
    {
        return JsonSerializer.Deserialize<AppSettings>(File.ReadAllText("appsettings.json"));
    }
}