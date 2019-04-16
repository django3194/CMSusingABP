using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Vishnu_MyProject.MultiTenancy;

namespace Vishnu_MyProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
