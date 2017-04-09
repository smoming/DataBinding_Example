using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataBinding_Example
{
	public partial class OneWayToSourcePage : ContentPage
	{
		public OneWayToSourcePage()
		{
			InitializeComponent();

			Device.StartTimer(TimeSpan.FromSeconds(1), () => {
				bindingValue.Text = myObject.MyValue;
				sliderValue.Text = slider1.Value.ToString();
				return true;
			});
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			//throw new NotImplementedException();
			myObject.MyValue = "0.9";
		}
	}
}
