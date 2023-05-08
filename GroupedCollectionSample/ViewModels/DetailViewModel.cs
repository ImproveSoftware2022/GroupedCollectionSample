using System;

namespace GroupedCollectionSample.ViewModels
{
	public class DetailViewModel : BaseViewModel
	{
		public Command BackCommand { get; set; }

		private void OnBackCommand()
		{
            IDictionary<string, object> navigationProperties = new Dictionary<string, object>()
            {
                    { "reload", false }
                };

            Shell.Current.GoToAsync("..", navigationProperties);
        }

        public DetailViewModel()
		{
            BackCommand = new Command(OnBackCommand);
        }
    }
}

