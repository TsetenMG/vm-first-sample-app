using System.Threading.Tasks;
using TestNavigationApp.ViewModels.Base;

namespace TestNavigationApp.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        protected override Task OnNext()
        {
            return NavigationService.PushAsync<SecondViewModel>();
        }
    }
}
