using System.Threading.Tasks;
using Abp.Application.Services;
using Abby.Sessions.Dto;

namespace Abby.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
