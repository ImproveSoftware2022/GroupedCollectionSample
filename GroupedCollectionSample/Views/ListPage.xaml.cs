using GroupedCollectionSample.ViewModels;

namespace GroupedCollectionSample.Views;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();

		this.BindingContext = new ListViewModel();
	}
}
