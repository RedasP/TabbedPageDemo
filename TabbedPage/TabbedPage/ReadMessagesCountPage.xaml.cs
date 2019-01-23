using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReadMessagesCountPage : ContentPage
	{
		public ReadMessagesCountPage ()
		{
			InitializeComponent ();

		    BindingContext = new ReadMessagesViewModel(10, 20);
		}
	}
}