using System.Threading.Tasks;
using Abp.Application.Services;
using Vishnu_MyProject.Authorization.Accounts.Dto;

namespace Vishnu_MyProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
