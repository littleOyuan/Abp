using System.Threading.Tasks;
using Abp.Application.Services;
using Abby.Authorization.Accounts.Dto;

namespace Abby.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
