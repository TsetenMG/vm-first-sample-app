using System.Threading.Tasks;
using TestNavigationApp.ViewModels.Base;

namespace TestNavigationApp.ViewModels
{
    public class ThirdViewModel : BaseViewModel
    {
        protected override Task OnNext()
        {
            return NavigationService.PushAsync<FourthViewModel>();
        }
    }
}
