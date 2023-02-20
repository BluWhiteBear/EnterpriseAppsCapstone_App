namespace BreadCrumbs;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    /* 
     Button Event Listener to navigate back to the home page
     */
    private void OnHomeButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
    }

    private void OnMainButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new HomePage(), true);
    }
}