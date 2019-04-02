using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QA.MultiTenancy.Dto;

namespace QA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

