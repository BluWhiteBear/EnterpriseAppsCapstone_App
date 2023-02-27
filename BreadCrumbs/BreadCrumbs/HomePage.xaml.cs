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
        public static string BaseAddress =
    DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8080" : "http://localhost:8080";
    public static string TodoItemsUrl = $"{BaseAddress}/destination?searchString";
}