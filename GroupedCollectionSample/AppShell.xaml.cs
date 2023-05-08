using GroupedCollectionSample.Views;

namespace GroupedCollectionSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(ListPage), typeof(ListPage));
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}

