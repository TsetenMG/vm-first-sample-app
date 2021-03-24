using TestNavigationApp.ViewModels.Base;
using Xamarin.Forms;

namespace TestNavigationApp.Pages.Base
{
    public class StartPage : ContentPage
    {
        private StartViewModel ViewModel;
        public StartPage()
        {
            ViewModel = new StartViewModel();

            BindingContext = ViewModel;
            Content = Build();
        }
        
        private Layout Build()
        {
            return new StackLayout
            {
                Children =
                {
                    new Label()
                    {
                        Margin = new Thickness(0,100,0,0),
                        Text = "Start here",
                        FontSize = 40,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center,
                    },
                    
                    new Button
                    {
                        Text = "GO",
                        FontSize = 30,
                        TextColor = Color.White,
                        BackgroundColor = Color.DodgerBlue,
                        Command = ViewModel.GoCommand
                    }
                }
            };
        }
    }
}
