using System;
using System.Collections.ObjectModel;
using OffCenter.Shared;
using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;

namespace MCA
{
	public class BeaconsViewModel : BaseViewModel
	{
		public BeaconsViewModel()
		{
			// Beacon.All
		}

		public IList<MBeacon> Beacons => Beacon.All.Select((KeyValuePair<Beacons, Beacon> arg) => new MBeacon(arg.Key)).ToList();

	}
}

