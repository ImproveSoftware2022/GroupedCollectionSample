using System;
using GroupedCollectionSample.Models;

namespace GroupedCollectionSample.Services
{
	public static class FacadeDataService
	{
		public static IEnumerable<User> GetData(bool enabledOnly)
		{
			List<User> usersDataSource = new List<User>()
			{
				new User
				{
					EmploymentDate = new DateTime(2023, 5, 8),
					FirstName = "John",
					LastName = "Gritt",
					Enabled = true
				},
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "Wayne",
                    LastName = "Rogers",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Waylon",
                    LastName = "Smithers",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Montgomery",
                    LastName = "Burns",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Homer",
                    LastName = "Simpson",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Mark",
                    LastName = "McCormick",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 1),
                    FirstName = "Francesco",
                    LastName = "Paolantoni",
                    Enabled = true
                },
                                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "John",
                    LastName = "Gritt",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "Wayne",
                    LastName = "Rogers",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Waylon",
                    LastName = "Smithers",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Montgomery",
                    LastName = "Burns",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Homer",
                    LastName = "Simpson",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Mark",
                    LastName = "McCormick",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 1),
                    FirstName = "Francesco",
                    LastName = "Paolantoni",
                    Enabled = true
                },

                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "John",
                    LastName = "Gritt",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "Wayne",
                    LastName = "Rogers",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Waylon",
                    LastName = "Smithers",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Montgomery",
                    LastName = "Burns",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Homer",
                    LastName = "Simpson",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Mark",
                    LastName = "McCormick",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 1),
                    FirstName = "Francesco",
                    LastName = "Paolantoni",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "John",
                    LastName = "Gritt",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 8),
                    FirstName = "Wayne",
                    LastName = "Rogers",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Waylon",
                    LastName = "Smithers",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 7),
                    FirstName = "Montgomery",
                    LastName = "Burns",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Homer",
                    LastName = "Simpson",
                    Enabled = true
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 3),
                    FirstName = "Mark",
                    LastName = "McCormick",
                    Enabled = false
                },
                new User
                {
                    EmploymentDate = new DateTime(2023, 5, 1),
                    FirstName = "Francesco",
                    LastName = "Paolantoni",
                    Enabled = true
                },
            };

			if (enabledOnly)
                return usersDataSource.Where(a => a.Enabled);
			else
				return usersDataSource;
		}
	}
}

