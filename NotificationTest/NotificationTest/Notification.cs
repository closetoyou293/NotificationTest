using MvvmHelpers;

namespace NotificationTest
{
    public class Notification : ObservableObject
    {
        private string _message;
        private bool _isRead;

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public bool IsRead
        {
            get => _isRead;
            set => SetProperty(ref _isRead, value);
        }
    }
}
