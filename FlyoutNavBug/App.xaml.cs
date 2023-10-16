namespace FlyoutNavBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FlyoutPage f = new FlyoutPage();
            f.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Split;
            f.Flyout = new FlyoutFlyoutPage();
            f.Detail = new ContentPage { Content = new Label { 
                HorizontalOptions= LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Center,
                Text = "WinUI only.\n" +
                "Pick NavigationPage A or B from the Flyout.\n" +
                "The Back-arrow is drawn only if the *first* one chosen has a page pushed to it.\n" +
                "Tapping it will pop a page from the *current* one chosen, if there is one to pop."} };

            MainPage = f;
        }
    }
}
