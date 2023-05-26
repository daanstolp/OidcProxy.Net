using GoCloudNative.Bff.Authentication.ModuleInitializers;
using Microsoft.Extensions.Configuration;

namespace GoCloudNative.Bff.Authentication.OpenIdConnect;

public static class ModuleInitializer
{
    public static void ConfigureOpenIdConnect(this BffOptions options, IConfigurationSection configurationSection, string endpointName = "account")
        => ConfigureOpenIdConnect(options, configurationSection.Get<OpenIdConnectConfig>(), endpointName);

    public static void ConfigureOpenIdConnect(this BffOptions options, OpenIdConnectConfig config, string endpointName = "account")
    {
        options.RegisterIdentityProvider<OpenIdConnectIdentityProvider, OpenIdConnectConfig>(config, endpointName);
    }
}