using System;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using TestNavigationApp.Pages;
using TestNavigationApp.Pages.Base;
using TestNavigationApp.ViewModels;
using TestNavigationApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestNavigationApp.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigationToStart()
        {
            var startPage = CreateInstance(typeof(StartViewModel), null);
            Application.Current.MainPage = startPage;
            return Task.CompletedTask;
        }
        
        public Task NavigationIntoApp()
        {
            var firstPage = CreateInstance(typeof(FirstViewModel), null);
            Application.Current.MainPage = new NavigationPage(firstPage);
            return Task.CompletedTask;
        }

        public async Task PushModalAsync<TViewModel>()
        {
            var page = CreateInstance(typeof(TViewModel), null);
            await Application.Current.MainPage.Navigation.PushModalAsync(page);
        }

        public async Task PushAsync<TViewModel>()
            where TViewModel : BaseViewModel
        {
            var page = CreateInstance(typeof(TViewModel), null);
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }

        public async Task PopToRoot()
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }

        private static Page CreateInstance(Type viewModelType, object parameter)
        {
            var pageType = GetPageTypeForViewModel(viewModelType);
            if (pageType == null)  
            {  
                throw new Exception($"Cannot locate page type for {viewModelType}");  
            }  

            var page = Activator.CreateInstance(pageType) as Page;  
            return page;  
        }
        
        private static Type GetPageTypeForViewModel(Type viewModelType)  
        {
            if (viewModelType.FullName == null) {
                throw new Exception($"ViewModelFullName is null");
            }

            var viewName = viewModelType.FullName.Replace("ViewModel", "Page");  
            var viewModelAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName;  
            var viewAssemblyName = string.Format(  
                CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);  
            var viewType = Type.GetType(viewAssemblyName);  
            return viewType;
        }  
    }
}
