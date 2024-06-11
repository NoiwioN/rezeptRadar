using Microsoft.Maui.Controls.Compatibility;
using static Java.Util.Jar.Attributes;
using static System.Net.Mime.MediaTypeNames;
using Application = Microsoft.Maui.Controls.Application;

namespace RezeptRadar.Pages;

public partial class Login_Form : ContentPage
{
    public bool validInputEmail;
    public bool validInputPassword;
	public Login_Form()
	{
		InitializeComponent();
	}

    private void entryEmail_Completed(object sender, EventArgs e)
    {
        var entry = sender as Entry;
            var parent = FindByName("parent") as VerticalStackLayout;
            String text = "Ungültige Email";
            var errorLabel = parent.Children[3] as Label;
            if (errorLabel != null)
            {
                parent.Children.RemoveAt(3);
            }
            if (entry.Text != null && entry.Text.Contains("@") && entry.Text.Contains("."))
            {
                validInputEmail = true;
            }
            else
            {
                if (entry.Text == "" || entry.Text == null)
                {
                    text = "Email darf nicht leer sein";
                }
                validInputEmail= false;


                var newLabel = new Label
                {
                    Text = text,
                    TextColor = (Color)Application.Current.Resources["error"],
                    FontFamily = "TahomaRegular",
                    FontSize = 14,
                    StyleId = "errorEmail"
                };

                if (parent.Children.Count >= 3)
                {
                    parent.Children.Insert(3, newLabel);
                }
                else
                {
                    parent.Children.Add(newLabel);
                }
            }
        checkButtonEnable();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var label = sender as Label;
        if (label != null)
        {
            label.Text = "In dem Fall solltest du ein Passwort Manager benutzen";
        }

    }
    private bool checkButtonEnable()
    {
        if(this.validInputEmail && this.validInputPassword)
        {
            loginButton.BackgroundColor = (Color)Application.Current.Resources["actionElement"];
        }
        else
        {
            loginButton.BackgroundColor = (Color)Application.Current.Resources["inactiveElement"];
        }
        return this.validInputEmail && this.validInputPassword;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if(checkButtonEnable())
        {
            var newLabel = new Label
            {
                Text = "Login Erfolgreich",
                TextColor = Colors.Green,
                Style = (Style)Application.Current.Resources["labelh2"],
            };
            parent.Children.Insert(2, newLabel);
            Thread.Sleep(1000);
            await Shell.Current.GoToAsync("//Home/Browse");



        }
    }

    private void entryPassword_Completed(object sender, EventArgs e)
    {
        
        var entry = sender as Entry;
        var parent = FindByName("parent") as VerticalStackLayout;
        String text = "Passwort darf nicht leer sein";
        var errorLabel = parent.Children[3] as Label;
        int index;
        if (errorLabel != null)
        {
            index = 5;
        }
        else
        {
            index = 4;
        }
        if ((parent.Children[index] as Label).Text== "Passwort darf nicht leer sein") {

            parent.Children.RemoveAt(index);
        }
        if (entry.Text !="" && entry.Text != null)
            {
                this.validInputPassword = true;
            }else
            {
                this.validInputPassword = false;
                var newLabel = new Label
                {
                    Text = text,
                    TextColor = (Color)Application.Current.Resources["error"],
                    FontFamily = "TahomaRegular",
                    FontSize = 14,
                };
                
               

                parent.Children.Insert(index, newLabel);
            }

        checkButtonEnable();
    }
}