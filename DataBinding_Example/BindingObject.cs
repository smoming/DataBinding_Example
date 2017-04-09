using System;
using Xamarin.Forms;

namespace DataBinding_Example
{
	public class BindingObject : BindableObject
	{
		public BindingObject()
		{
			Device.StartTimer(TimeSpan.FromSeconds(1), () =>
			{
				CurrentTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
				return true;
			});
		}

		public static readonly BindableProperty MyValueProperty =
			BindableProperty.Create(
				"MyValue", 
				typeof(string), 
				typeof(BindingObject), 
				"ASD");

		public string MyValue
		{
			get { return (string)GetValue(MyValueProperty); }
			set { SetValue(MyValueProperty, value); }
		}

		public static readonly BindableProperty CurrentTimeProperty =
			BindableProperty.Create(
				"CurrentTime",
				typeof(string),
				typeof(BindingObject));

		public string CurrentTime
		{
			get { return (string)GetValue(CurrentTimeProperty); }
			private set { SetValue(CurrentTimeProperty, value); }
		}
	}
}
