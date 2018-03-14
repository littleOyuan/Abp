using System.Threading.Tasks;
using Abby.Configuration.Dto;

namespace Abby.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
