using Backend.dtos;
using Backend.dtos.products;
using Backend.EndPoints.Products;
using Microsoft.AspNetCore.Http.HttpResults;



var builder = WebApplication.CreateBuilder(args);

// we will add the validation service here
builder.Services.AddValidation();

var app = builder.Build();


// we will register the routes for the app here
app.AllProductEndPoints();

app.Run();
