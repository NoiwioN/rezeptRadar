namespace RezeptRadar.Pages;

public partial class ShoppingList : ContentPage
{
	public ShoppingList()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		var checkBox = sender as CheckBox;
		if (checkBox != null)
		{
			if (checkBox.IsChecked)
			{
				checkBox.Color = (Color)Application.Current.Resources["success"];

			}
			else
			{
                checkBox.Color = (Color)Application.Current.Resources["inactiveElement"];
            }
        }
    }
}