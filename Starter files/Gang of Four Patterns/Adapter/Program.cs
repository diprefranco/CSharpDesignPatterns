using Adapter;

Console.Title = "Adapter";

// object adapter example
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.Fullname}, {city.Inhabitants}");
Console.ReadKey();
