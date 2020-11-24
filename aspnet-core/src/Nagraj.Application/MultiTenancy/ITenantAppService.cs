using Abp.Application.Services;
using Nagraj.MultiTenancy.Dto;

namespace Nagraj.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

