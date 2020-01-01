using galahad.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace galahad.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Group> m_Groups;
        public ObservableCollection<Group> Groups {
            get { return m_Groups; }
            set {
                if (m_Groups != value)
                {
                    m_Groups = value;
                    OnPropertyChanged(nameof(Groups));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
                return;

            backingField = value;

            OnPropertyChanged(propertyName);
        }
    }
}
