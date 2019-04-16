using System.Threading.Tasks;
using Abp.Application.Services;
using Vishnu_MyProject.Sessions.Dto;

namespace Vishnu_MyProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
