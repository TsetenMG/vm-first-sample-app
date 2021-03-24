using TestNavigationApp.ViewModels;
using Xamarin.Forms;

namespace TestNavigationApp.Pages
{
    public class ModalPage : ContentPage
    {
        private ModalViewModel ViewModel;

        public ModalPage()
        {
            ViewModel = new ModalViewModel();

            BindingContext = ViewModel;
            Content = Build();
        }
        
        private Layout Build()
        {
            return new StackLayout
            {
                Margin = new Thickness(0,20,0,60),
                Children =
                {
                    new Label()
                    {
                        Text = "This is a ModalPage",
                        FontSize = 20,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    
                    new Button
                    {
                        Text = "Close",
                        Command = ViewModel.CloseCommand
                    }
                    
                }
            };
        }
    }
}
