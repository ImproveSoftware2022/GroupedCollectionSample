using GroupedCollectionSample.ViewModels;

namespace GroupedCollectionSample.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();

		this.BindingContext = new DetailViewModel();
	}
}
