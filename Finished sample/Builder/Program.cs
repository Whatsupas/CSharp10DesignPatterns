using BuilderPattern;
using FluentBuilder;


//Director director = new Director();

//Builder b1 = new ConcreteBuilder1();
//Builder b2 = new ConcreteBuilder2();

//// Construct two products
//director.Construct(b1);
//Product p1 = b1.GetResult();
//p1.Show();

//director.Construct(b2);
//Product p2 = b2.GetResult();
//p2.Show();




var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());
// or: 
garage.Show();

garage.Construct(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());
// or: 
garage.Show();

Console.WriteLine();
Console.WriteLine("Fluent Builder");

var defaultBus = new Bus();
defaultBus.Show();

var bus = new Bus.BusBuilder().WithModel("Volvo").WithColor("Red").WithManufactureYear(2005).Build();
bus.Show();

var anotherBus = new Bus.BusBuilder().WithModel("Volvo").WithManufactureYear(2010).Build();
anotherBus.Show();

Console.ReadKey();