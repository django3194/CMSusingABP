using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Vishnu_MyProject.Roles.Dto;
using Vishnu_MyProject.Users.Dto;

namespace Vishnu_MyProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
