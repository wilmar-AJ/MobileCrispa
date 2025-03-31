namespace ApiWoman;




public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("users", typeof(Pages.UserPage));
    }
}
