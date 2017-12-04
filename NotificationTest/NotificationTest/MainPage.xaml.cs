using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotificationTest
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;
        public MainPage()
        {
            InitializeComponent();
            _vm = new MainPageViewModel();
            BindingContext = _vm;
        }

        private void OnTapped(object sender, ItemTappedEventArgs e)
        {
            _vm.TappedCommand.Execute(e.Item);
        }

        private void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            NotiList.SelectedItem = null;
        }
    }
}
