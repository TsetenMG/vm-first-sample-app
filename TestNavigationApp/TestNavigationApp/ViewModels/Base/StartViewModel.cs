using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestNavigationApp.ViewModels.Base
{
    public class StartViewModel : BaseViewModel
    {
        public readonly Command GoCommand;

        public StartViewModel()
        {
            GoCommand = new Command(GoIntoApp);
        }

        private void GoIntoApp()
        {
            NavigationService.NavigationIntoApp();
        }
    }
}
