namespace FlyoutNavBug;

public partial class FlyoutFlyoutPage : ContentPage
{
    private readonly Page _first;
    private readonly Page _second;

    public FlyoutFlyoutPage()
	{
		InitializeComponent();

        _first = new  NavigationPage(new MainPage("first", 0));
        _second = new NavigationPage(new MainPage("second", 0));
    }

    private void Button_Clicked1(object sender, EventArgs e)
    {
        ((FlyoutPage)this.Parent).Detail = _first;
    }
    private void Button_Clicked2(object sender, EventArgs e)
    {
        ((FlyoutPage)this.Parent).Detail = _second;

    }
}