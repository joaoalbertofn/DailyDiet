using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DailyDiet
{
	public class MainViewModel
	{
		// DataSet
		public ObservableCollection<Meal> Meals { get; set; }


		// Command PlusMeal
		public ICommand PlusMealCommand { get; set; }
		private async void PlusMeal()
		{
			await DailyDiet.App.Current.MainPage.Navigation.PushAsync(new NewMeal());
			//Navigation.PushAsync(new NewMeal());
		}



		public MainViewModel()
		{
			LoadMaels();
			PlusMealCommand = new Command(this.PlusMeal);
		}


		// Load meals
		private void LoadMaels()
		{ 
			
		}



	}
}

