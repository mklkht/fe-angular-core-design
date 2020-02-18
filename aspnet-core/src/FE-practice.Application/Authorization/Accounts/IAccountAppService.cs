using System.Threading.Tasks;
using Abp.Application.Services;
using FE-practice.Authorization.Accounts.Dto;

namespace FE-practice.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
