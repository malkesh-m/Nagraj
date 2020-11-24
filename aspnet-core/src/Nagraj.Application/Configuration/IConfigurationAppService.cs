using System.Threading.Tasks;
using Nagraj.Configuration.Dto;

namespace Nagraj.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
