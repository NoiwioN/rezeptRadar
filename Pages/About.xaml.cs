using System.Windows.Input;

namespace RezeptRadar.Pages;

public partial class About : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public About()
	{
		InitializeComponent();
        BindingContext = this;
    }
}