namespace FlyoutNavBug
{
    public partial class MainPage : ContentPage
    {
        private readonly string _name;

        int Depth { get; }
        public MainPage(string name, int depth)
        {
            InitializeComponent();
            _name = name;
            Depth = depth;
            TheLabel.Text=$"This is the {_name} page. It is at stack depth {Depth}";
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage(_name, Depth+1));
        }
    }

}
