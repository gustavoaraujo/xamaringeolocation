using Xamarin.Forms;
using System;
using System.Diagnostics;
using Plugin.Geolocator;

namespace xamarin.geolocation
{
	public partial class xamarin_geolocationPage : ContentPage
	{
		public string Teste { get; set; } = "Teste";

		public xamarin_geolocationPage()
		{
			GetLocation();
			InitializeComponent();
		}

		public async void GetLocation()
		{
			try
			{
				var locator = CrossGeolocator.Current;
				locator.DesiredAccuracy = 50;

				var position = await locator.GetPositionAsync(10000);
				if (position == null)
					return;

				this.lblLatitude.Text = string.Format("Latitude: {0}", position.Latitude);
				this.lblLongitude.Text = string.Format("Longitude: {0}", position.Longitude);

				Debug.WriteLine("Position Status: {0}", position.Timestamp);
				Debug.WriteLine("Position Latitude: {0}", position.Latitude);
				Debug.WriteLine("Position Longitude: {0}", position.Longitude);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Unable to get location, may need to increase timeout: " + ex);
			}
		}
	}
}
