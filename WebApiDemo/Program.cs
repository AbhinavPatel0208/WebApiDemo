var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();

//This is Minimal Routing For Web API
// "/shirts"

//Read All Shirt
/*app.MapGet("/shirts",()=>
{
    return "Reading all the shirts";
});

//Read a shirt using Id
app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading Shirt with ID:{id}";
});

//Create a shirt
app.MapPost("/shirts", () =>
{
    return "Creating a shirt";
});

//Update the shirt
app.MapPut("/shirts/{id}", (int id) => {
    return $"Updating shirt with Id: {id}";
});

//Delete the shirt
app.MapDelete("/shirts/{id}", (int id) => {
    return $"Deleting Shirt with Id : {id}";
});*/


app.Run();
