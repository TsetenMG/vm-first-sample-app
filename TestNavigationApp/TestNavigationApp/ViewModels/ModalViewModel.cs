using TestNavigationApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestNavigationApp.ViewModels
{
    public class ModalViewModel : BaseViewModel
    {
        public readonly Command CloseCommand;

        public ModalViewModel()
        {
            CloseCommand = new Command(Close);
        }

        private void Close()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
