using Cocona;

var builder = CoconaLiteApp.CreateBuilder();
var app = builder.Build();

app.AddCommands<CalcCommands>();
app.Run();