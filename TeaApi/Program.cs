var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var teaVarieties = new[]
{
   "Black", "Green", "White", "Oolong", "Pu-erh", "Yellow", "Herbal", "Rooibos", "Mate", "Chamomile"
};

app.MapGet("/tea", () =>
{
    return teaVarieties[Random.Shared.Next(teaVarieties.Length)];
});

app.Run();
