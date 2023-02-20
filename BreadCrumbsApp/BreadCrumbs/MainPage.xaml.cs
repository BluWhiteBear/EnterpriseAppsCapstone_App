namespace BreadCrumbs;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    /* 
     Button Click Listener method for going to login page
     */
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage(), true);
    }
}
