using System.Threading.Tasks;
using FE-practice.Configuration.Dto;

namespace FE-practice.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
