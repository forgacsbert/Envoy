var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var coffeeVarieties = new[]
{
    "Long", "Short", "Latte", "Cappuccino", "Espresso", "Americano", "Macchiato", "Mocha", "Flat White", "Affogato"
};

app.MapGet("/coffee", () =>
{
    return coffeeVarieties[Random.Shared.Next(coffeeVarieties.Length)];
});

app.Run();