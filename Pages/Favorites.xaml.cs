using RezeptRadar.Models;

namespace RezeptRadar.Pages;

public partial class Favorites : ContentPage
{
	public Favorites()
	{
		InitializeComponent();
        var itemsDaily = new List<CollectionItem>
        {

            new CollectionItem{Title="Tofu Edamame Bowl 1", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 2", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 3", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 4", Description= "Add 11 Ingredients", Image= "bowl.jpg"},
            new CollectionItem{Title="Tofu Edamame Bowl 5", Description= "Add 11 Ingredients", Image= "bowl.jpg"}
        };
        carouselViewDaily.ItemsSource = itemsDaily;
    }
    private async void recipieClicked(object sender, TappedEventArgs e)
    {
        Routing.RegisterRoute("recipiePage", typeof(RezeptSeite));
        await Shell.Current.GoToAsync("recipiePage");

    }

    private void buttonTypeBeat_Clicked(object sender, EventArgs e)
    {

    }
}