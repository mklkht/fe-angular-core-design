using System.Threading.Tasks;
using Abp.Application.Services;
using FE-practice.Sessions.Dto;

namespace FE-practice.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
