namespace RezeptRadar.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Login_Clicked (object sender, EventArgs e)
    {
        Routing.RegisterRoute("Login_Form", typeof(Login_Form));
        await Shell.Current.GoToAsync("Login_Form");
    }

    private void Register_Clicked (object sender, EventArgs e)
    {

    }
}