using System.Threading.Tasks;
using TestNavigationApp.ViewModels.Base;

namespace TestNavigationApp.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
        protected override Task OnNext()
        {
            return NavigationService.PushAsync<ThirdViewModel>();
        }
    }
}
