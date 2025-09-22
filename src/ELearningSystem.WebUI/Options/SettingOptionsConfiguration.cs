using Microsoft.Extensions.Options;

namespace ELearningSystem.WebUI.Options;

public class SettingOptionsConfiguration(IConfiguration _configuration) : IConfigureOptions<AppSettings>
{
    public void Configure(AppSettings options)
    {
        _configuration.GetSection("AppSettings").Bind(options);
    }
}
