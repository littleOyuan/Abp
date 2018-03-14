using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abby.MultiTenancy.Dto;

namespace Abby.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
