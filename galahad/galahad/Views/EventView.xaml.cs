using galahad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace galahad.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventView : ContentView
    {
        public EventView()
        {
            InitializeComponent();

            ViewModel = new EventViewModel();

        }

        public EventViewModel ViewModel {
            get { return BindingContext as EventViewModel; }
            set { BindingContext = value; }
        }
    }
}