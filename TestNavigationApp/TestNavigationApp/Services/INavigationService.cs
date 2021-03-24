using System.Threading.Tasks;
using TestNavigationApp.ViewModels.Base;

namespace TestNavigationApp.Services
{
    public interface INavigationService
    {
        Task NavigationToStart();
        Task NavigationIntoApp();
        Task PushModalAsync<TViewModel>();
        Task PushAsync<TViewModel>() where TViewModel : BaseViewModel;
        Task PopToRoot();
    }
}
