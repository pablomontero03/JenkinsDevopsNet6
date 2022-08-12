var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "GET - Net 6 Running ... 18052022-v1.0.0 CI/CD in jenkins in job Pablo Montero Devops 2 ";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST - Net 6 Running ... 22042022-v1.0.0 CI/CD in jenkins in job Pablo Montero Devops 2";
});

app.Run();

