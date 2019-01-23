using System;
using System.Collections.Generic;
using System.Text;

namespace TabbedPage.ViewModels
{
    public class ReadMessagesViewModel : TabbedPageViewModel
    {
        public ReadMessagesViewModel(int readMessagesCount, int unreadMessagesCount) : base(readMessagesCount, unreadMessagesCount)
        {
        }
    }
}
