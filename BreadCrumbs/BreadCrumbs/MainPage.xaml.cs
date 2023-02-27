using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint;

namespace BreadCrumbs;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    /* 
     Button Click Listener method for testing fingerprint authorization
     */
    private async void Button_Clicked(Object sender, EventArgs e)
    {
        var availabiliity = await
           CrossFingerprint.Current.IsAvailableAsync();

        if (!availabiliity)
        {
            await DisplayAlert("Warning!", "No Biometrics available", "OK");

            return;
        }

        var request = new AuthenticationRequestConfiguration("Login using Biometrics!",
            "Confirm login with biometrics")
        {
            FallbackTitle = "Use PIN",
            AllowAlternativeAuthentication = true
        };

        var authResult = await CrossFingerprint.Current.AuthenticateAsync(request);

        if (authResult.Authenticated)
        {
            //do something if true
            await DisplayAlert("Authenticated!", "Access Granted", "OK");
        }
        else
        {
            //do something if false
            await DisplayAlert("Not authenticated!", "Access denied", "OK");
        }
    }

    /* 
     Button Click Listener method for going to login page
     */
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage(), true);
    }
}
