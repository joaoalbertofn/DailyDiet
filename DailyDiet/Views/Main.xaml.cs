using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DailyDiet
{
	public partial class Main : ContentPage
	{
		public Main()
		{
			InitializeComponent();
			BindingContext = new MainPageViewModel();
		}
	}
}

