using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Net;
using Microsoft.JSInterop;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Maui;

public class WeatherData
{
	[JsonProperty("location")]
	public Location Location { get; set; }

	[JsonProperty("current")]
	public CurrentCondition CurrentCondition { get; set; }

	public WeatherData GetWeather(string location)
	{
		string url = $"http://api.weatherapi.com/v1/current.json?key=87e4076f50604be0b46182808230905&q={location}&aqi=no";
		WebClient wc = new WebClient();

		string weatherJson = wc.DownloadString(url);
		WeatherData data = JsonConvert.DeserializeObject<WeatherData>(weatherJson);

		SaveWeather(weatherJson);
		return data;
	}

	private void SaveWeather(string json)
	{
		Preferences.Set("weather", json);
	}

	public WeatherData GetSavedWeather()
	{
		string json = Preferences.Get("weather", null);

		if(json != null)
		{
            WeatherData weather = JsonConvert.DeserializeObject<WeatherData>(json);
            return weather;
        }
		return null;
	}
}

public class Location
{
	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("region")]
	public string Region { get; set; }

	[JsonProperty("country")]
	public string Country { get; set; }
}

public class CurrentCondition
{
	[JsonProperty("temp_c")]
	public double TemperatureCelsius { get; set; }

	[JsonProperty("condition")]
	public Condition Condition { get; set; }

	[JsonProperty("wind_kph")]
	public double WindSpeedKph { get; set; }
}

public class Condition
{
	[JsonProperty("text")]
	public string Text { get; set; }
}
