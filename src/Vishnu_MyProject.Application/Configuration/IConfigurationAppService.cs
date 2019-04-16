using System.Threading.Tasks;
using Vishnu_MyProject.Configuration.Dto;

namespace Vishnu_MyProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
