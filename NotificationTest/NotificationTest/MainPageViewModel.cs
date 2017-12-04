using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace NotificationTest
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Notification> _notifications;

        public ObservableCollection<Notification> Notifications
        {
            get => _notifications;
            set => SetProperty(ref _notifications, value);
        }

        public ICommand TappedCommand => new Command((o => OnTapped(o)));

        public MainPageViewModel()
        {
            _notifications = new ObservableCollection<Notification>()
            {
                new Notification()
                {
                    IsRead = false,
                    Message = "First notification"
                },
                new Notification()
                {
                    IsRead = false,
                    Message = "Second notification"
                },
                new Notification()
                {
                    IsRead = false,
                    Message = "Third notification"
                },
                new Notification()
                {
                    IsRead = false,
                    Message = "Fourth notification"
                }
            };
        }

        private void OnTapped(object o)
        {
            if(!(o is Notification noti)) return;

            noti.IsRead = true;
        }
    }
}
