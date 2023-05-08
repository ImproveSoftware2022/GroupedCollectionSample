using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace GroupedCollectionSample.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetPropertyValue<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (value == null ? field != null : !value.Equals(field))
            {
                field = value;

                var handler = this.PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
                return true;
            }
            return false;
        }

        public void NavigateToPreviousPage()
        {
            NavigateToPreviousPage(string.Empty);
        }

        public void NavigateToPreviousPage(string navigationProperty)
        {
            Shell.Current.GoToAsync($"..?{navigationProperty}");
        }
    }
}

