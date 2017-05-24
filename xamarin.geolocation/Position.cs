using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace xamarin.geolocation
{
	public class Position : INotifyPropertyChanged
	{
		private DateTimeOffset timestamp;
		private double latitude;
		private double longitude;

		public DateTimeOffset Timestamp 
		{ 
			get { return timestamp; } 
			set 
			{
				timestamp = value;

				if (PropertyChanged != null) 
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Timestamp"));
				}
			} 
		}

		public double Latitude 
		{
			get { return latitude; }
			set
			{
				latitude = value;

				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Latitude"));
				}
			}
		}

		public double Longitude 
		{
			get { return longitude; }
			set
			{
				longitude = value;

				if (PropertyChanged != null)
				{
					PropertyChanged(this, new PropertyChangedEventArgs("Longitude"));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
