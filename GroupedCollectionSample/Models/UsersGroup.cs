using System;
using GroupedCollectionSample.Semplice.Helpers;

namespace GroupedCollectionSample.Models
{
	public class UsersGroup : ObservableRangeCollection<User>
	{
        public DateTime Date { get; private set; }

        public UsersGroup(DateTime date, ObservableRangeCollection<User> users) : base(users)
        {
            Date = date;
        }
    }
}

