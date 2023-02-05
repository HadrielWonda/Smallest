var app = WebApplication.CreateBuilder(args).Build();

app.MapGet("/",() => "Hadriel's Smallest ever Api🤩🤩");

app.Run();
