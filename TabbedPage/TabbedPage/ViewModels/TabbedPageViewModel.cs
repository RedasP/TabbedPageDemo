using System.Windows.Input;
using Xamarin.Forms;

namespace TabbedPage.ViewModels
{
    public class TabbedPageViewModel : BaseViewModel
    {
        private int _readMessagesCount;
        private int _unreadMessagesCount;

        public TabbedPageViewModel(int readMessagesCount, int unreadMessagesCount)
        {
            _readMessagesCount = readMessagesCount;
            _unreadMessagesCount = unreadMessagesCount;
        }
        public int ReadMessagesCount
        {
            get => _readMessagesCount;
            set
            {
                _readMessagesCount = value;
                OnPropertyChanged();
            }
        }

        public int UnreadMessagesCount
        {
            get => _unreadMessagesCount;
            set
            {
                _unreadMessagesCount = value;
                OnPropertyChanged();
            }
        }

        public ICommand ButtonCommand => new Command((() =>
        {
            ReadMessagesCount++;
            UnreadMessagesCount++;
        }));

       
    }
}
