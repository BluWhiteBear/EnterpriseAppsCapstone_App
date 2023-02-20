namespace BreadCrumbs;

public partial class HomePage : ContentPage
{
    public HomePage()
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
}