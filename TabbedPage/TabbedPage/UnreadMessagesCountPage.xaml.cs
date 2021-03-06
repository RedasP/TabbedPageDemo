﻿using System;
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
	public partial class UnreadMessagesCountPage : ContentPage
	{
		public UnreadMessagesCountPage ()
		{
			InitializeComponent ();

            BindingContext = new UnreadMessagesViewModel(20, 10);
		}
	}
}