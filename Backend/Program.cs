using Backend.Data;
using Backend.dtos;
using Backend.dtos.products;
using Backend.EndPoints.Products;
using Microsoft.AspNetCore.Http.HttpResults;



var builder = WebApplication.CreateBuilder(args);

// we will add the validation service here
builder.Services.AddValidation();

// the database connection will be defined here
const string ConnectionString = "Data Source=OnlineStore.db";
// we have to add the dependency for the database connection
builder.Services.AddSqlite<AppDbContext>(connectionString: ConnectionString);

var app = builder.Build();


// we will register the routes for the app here
app.AllProductEndPoints();

app.Run();
