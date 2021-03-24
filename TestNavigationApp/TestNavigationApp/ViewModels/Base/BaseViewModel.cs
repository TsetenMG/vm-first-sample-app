using System;
using System.Threading.Tasks;
using Autofac;
using TestNavigationApp.Pages;
using TestNavigationApp.Services;
using Xamarin.Forms;

namespace TestNavigationApp.ViewModels.Base
{
    public class BaseViewModel
    {
        protected readonly INavigationService NavigationService;

        public Command QuitButtonCommand { get; }
        public Command NextButtonCommand { get; }
        public Command BackButtonCommand { get; }
        public Command BackToRootButtonCommand { get; private set; }
        public Command OpenModalPageButtonCommand { get; }

        protected BaseViewModel()
        {
            NavigationService = IocContainer.Container.Resolve<INavigationService>();

            NextButtonCommand = new Command(() => OnNext());
            BackButtonCommand = new Command(OnBack);
            BackToRootButtonCommand = new Command(async () => await OnBackToRoot());
            OpenModalPageButtonCommand = new Command(() => OnOpenModalPage());
            QuitButtonCommand = new Command(QuitToStart);
        }

        private void QuitToStart()
        {
            NavigationService.NavigationToStart();
        }

        protected virtual Task OnNext()
        {
            return Task.CompletedTask;
        }

        private static void OnBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
        
        private async Task OnBackToRoot()
        {
            await NavigationService.PopToRoot();
        }
        
        private async Task OnOpenModalPage()
        {
            await NavigationService.PushModalAsync<ModalViewModel>();
        }
    }
}
