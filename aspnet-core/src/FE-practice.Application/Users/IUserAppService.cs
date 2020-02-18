using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FE-practice.Roles.Dto;
using FE-practice.Users.Dto;

namespace FE-practice.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
