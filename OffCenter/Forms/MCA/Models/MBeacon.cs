using System;
using OffCenter.Shared;

namespace MCA
{
	public class MBeacon
	{
		public MBeacon(Beacons beacon)
		{
			Name = beacon.ToString();
			Icon = $"i_beacon_{Name.ToLowerInvariant()}";
		}


		public string Name { get; set; }

		public string Icon { get; set; }
	}
}
