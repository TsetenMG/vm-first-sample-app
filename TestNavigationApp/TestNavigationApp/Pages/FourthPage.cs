using TestNavigationApp.ViewModels;
using Xamarin.Forms;

namespace TestNavigationApp.Pages
{
    public class FourthPage : ContentPage
    {
        private FourthViewModel ViewModel;
        
        public FourthPage()
        {
            ViewModel = new FourthViewModel();
            NavigationPage.SetHasNavigationBar(this,false);

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
                    new Button
                    {
                        Margin = new Thickness(0,100,0,0),
                        Text = "Quit to start",
                        Command = ViewModel.QuitButtonCommand
                    },

                    new Label()
                    {
                        Text = "Page 4",
                        FontSize = 20,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    
                    new Button
                    {
                        Text = "Open ModalPage",
                        Command = ViewModel.OpenModalPageButtonCommand
                    },
                    
                    new Button
                    {
                        Text = "Back",
                        VerticalOptions = LayoutOptions.End,
                        Command = ViewModel.BackButtonCommand
                    },
                    
                    new Button
                    {
                        Text = "Next",
                        VerticalOptions = LayoutOptions.End,
                        Command = ViewModel.NextButtonCommand
                    },
                    
                    new Button
                    {
                        Text = "Back To Root",
                        VerticalOptions = LayoutOptions.End,  
                        Command = ViewModel.BackToRootButtonCommand
                    },
                }
            };
        }
    }
}
