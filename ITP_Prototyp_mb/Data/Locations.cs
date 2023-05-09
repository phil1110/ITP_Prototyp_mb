using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ITP_Prototyp_mb.Data
{
	public class Locations
	{
		private IJSRuntime jsRuntime;
		private List<string> _locations;

		public List<string> GetLocations()
		{
			string json = Preferences.Get("locations", null);

			if(json == null)
			{
				return _locations = new List<string>();
			}

			_locations = JsonSerializer.Deserialize<List<string>>(json);
			return _locations;
		}

		public void AddLocation(string location)
		{
			if(_locations == null)
			{
				GetLocations();
			}

			_locations.Add(location);

			var json = JsonSerializer.Serialize(_locations);
			Preferences.Set("locations", json);
		}
	}
}
