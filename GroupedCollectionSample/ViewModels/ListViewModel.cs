using System;
using System.Collections.ObjectModel;
using System.Net;
using GroupedCollectionSample.Models;
using GroupedCollectionSample.Semplice.Helpers;
using GroupedCollectionSample.Services;
using GroupedCollectionSample.Views;

namespace GroupedCollectionSample.ViewModels
{
	public class ListViewModel : BaseViewModel, IQueryAttributable
	{
        #region property

        private bool filterData;
        public bool FilterData
        {
            get => filterData;
            set => filterData = value;
        }

        private ObservableCollection<UsersGroup> listUsersGroup;
        public ObservableCollection<UsersGroup> ListUsersGroup
        {
            get => listUsersGroup;
            set => SetPropertyValue(ref listUsersGroup, value);
        }

        private User currentUser;
        public User CurrentUser
        {
            get => currentUser;
            set => SetPropertyValue(ref currentUser, value);
        }

        public Command FilterDataCommand { get; set; }
        public Command OpenDetailCommand { get; set; }
        #endregion

        #region commands handlers

        private void OnFilterDataToggled()
        {
            LoadData();
        }

        private void OnOpenDetailTapped()
        {
            OpenDetail();
        }
        #endregion

        #region ctor
        public ListViewModel()
        {
            Inizializza();

            LoadData();
        }
        #endregion

        #region metodi
        private void Inizializza()
        {
            OpenDetailCommand = new Command(OnOpenDetailTapped);
            FilterDataCommand = new Command(OnFilterDataToggled);

            FilterData = true;
        }

        public void LoadData()
        {
            try
            {
                //if (CurrentUser is not null)
                //    CurrentUser = null;

                ListUsersGroup = new();

                IEnumerable<UsersGroup> grpUsers = LoadDataSub();

                if (grpUsers != null && grpUsers.Any())
                    ListUsersGroup = new ObservableRangeCollection<UsersGroup>(grpUsers.OrderByDescending(s => s.Date));
                else
                    // In questo modo visualizzo il testo Nessuna assegnazione in corso.
                    ListUsersGroup = new();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private IEnumerable<UsersGroup> LoadDataSub()
        {
            IEnumerable<User> users = FacadeDataService.GetData(filterData);

            return users.GroupBy(a => a.EmploymentDate.Date)
                .Select(a => new UsersGroup(a.Key, new ObservableRangeCollection<User>(a)));
        }

        private void OpenDetail()
        {
            Dictionary<string, object> dict = new()
            {
                { "users", listUsersGroup?.SelectMany(a => a.ToList()).ToList() }
            };

            Shell.Current.GoToAsync(nameof(DetailPage), dict);
        }
        #endregion

        #region ApplyQueryAttributes method
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            bool load = true;

            if (query != null && query.TryGetValue("reload", out object reload))
                load = (bool)reload;

            if (load)
                LoadData();
        }
        #endregion
    }
}

