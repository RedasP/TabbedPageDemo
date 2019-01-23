using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPage.ViewModels;
using Xamarin.Forms;

namespace TabbedPage
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            BindingContext = CurrentPage.BindingContext;
        }
    }
}
