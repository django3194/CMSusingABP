using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Vishnu_MyProject.MultiTenancy.Dto;

namespace Vishnu_MyProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

