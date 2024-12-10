using FactoryMethod;

Console.Title = "Factory Method";
//The key point here is that the client (Program.cs) does not know about any concrete implementations.
//The client depends on the asbtract classes (theorical speaking, contracts, not concrete implementations).

//In this example, two concrete products were created by our two concrete factories without the client having to know about concrete implementations.
var factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("BE")
};

foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
}

Console.ReadKey();
