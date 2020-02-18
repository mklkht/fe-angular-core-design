using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FE-practice.MultiTenancy.Dto;

namespace FE-practice.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

