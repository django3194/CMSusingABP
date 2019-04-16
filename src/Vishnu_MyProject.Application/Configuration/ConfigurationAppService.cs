using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Vishnu_MyProject.Configuration.Dto;

namespace Vishnu_MyProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Vishnu_MyProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
