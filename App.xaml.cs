namespace pmonterosExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new views.login());
        }

       /* protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new views.login()));
        }*/
    }
}