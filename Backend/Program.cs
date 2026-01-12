using Backend.dtos;
using Backend.dtos.products;
using Microsoft.AspNetCore.Http.HttpResults;



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string ApiRouteName = "GetProducts";

// the simple list of all games here
List<ProductDto> products =
[
    new(
        1,
        "Wireless Mouse",
        "Ergonomic wireless mouse with adjustable DPI",
        "Electronics",
        18999M,
        true,
        new DateOnly(2026, 1, 3),
        new DateOnly(2026, 1, 3)
    ),
    new(
        2,
        "Mechanical Keyboard",
        "RGB backlit mechanical keyboard with blue switches",
        "Electronics",
        74999M,
        true,
        new DateOnly(2026, 1, 3),
        new DateOnly(2026, 1, 3)
    ),
    new(
        3,
        "Laptop Stand",
        "Adjustable aluminum laptop stand for better ergonomics",
        "Accessories",
        32999M,
        true,
        new DateOnly(2026, 1, 3),
        new DateOnly(2026, 1, 3)
    ),
    new(
        4,
        "USB-C Hub",
        "7-in-1 USB-C hub with HDMI and Ethernet support",
        "Accessories",
        45999M,
        false,
        new DateOnly(2026, 1, 3),
        new DateOnly(2026, 1, 3)
    ),
    new(
        5,
        "Noise Cancelling Headphones",
        "Over-ear headphones with active noise cancellation",
        "Audio",
        129999M,
        true,
        new DateOnly(2026, 1, 3),
        new DateOnly(2026, 1, 3)
    )
];


// fetching all the products here
app.MapGet("/products", () => products);

// getting a single product here
// /products/{id}
app.MapGet("/products/{id}", (int id) => products.Find(product => product.ProductId == id)).WithName(ApiRouteName);

// adding a new product here
app.MapPost("/products", (CreateProductDto newProduct) =>
{
    ProductDto productDto = new(
        products.Count+1,
        newProduct.ProductTitle,
        newProduct.ProductDescription,
        newProduct.ProductCategory,
        newProduct.ProductPrice,
        newProduct.IsComplete,
        newProduct.CreatedAt,
        newProduct.UpdatedAt
    );

    // we have to add the product to the list of products here
    products.Add(productDto);

    // we have to return something here
    return Results.CreatedAtRoute(ApiRouteName, new {id = productDto.ProductId}, productDto);

});

// for updating the product here 
app.MapPut("/products/{id}", (int id, UpdateProductDto updateProductDto) =>
{

   // we will have to get the product that we want to update first
   var index = products.FindIndex(product => product.ProductId == id);

   products[index] = new ProductDto(
    id,
    updateProductDto.ProductTitle,
    updateProductDto.ProductDescription,
    updateProductDto.ProductCategory,
    updateProductDto.ProductPrice,
    updateProductDto.IsComplete,
    updateProductDto.CreatedAt,
    updateProductDto.UpdatedAt
   );
   

});



app.Run();
