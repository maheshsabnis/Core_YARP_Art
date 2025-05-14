using CommoEntities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

 

app.MapGet("/products", () =>
{
    var products = new DataStore.Products();
    return Results.Ok(products);
});

app.MapPost("/products", (Product prd) =>
{
    var products = new DataStore.Products();
    products.Add(prd);
    return Results.Ok(products);
});

app.Run();

 