using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedPage.ViewModels
{
    public class UnreadMessagesViewModel : TabbedPageViewModel
    {
        public UnreadMessagesViewModel(int readMessagesCount, int unreadMessagesCount) : base(readMessagesCount, unreadMessagesCount)
        {
        }
    }
}
