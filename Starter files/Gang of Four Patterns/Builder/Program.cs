using BuilderPattern;

Console.Title = "Builder";

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
//Console.WriteLine(miniBuilder.Car.ToString());
garage.Show();

garage.Construct(bmwBuilder);
//Console.WriteLine(bmwBuilder.Car.ToString());
garage.Show();

Console.ReadKey();
