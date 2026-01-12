using Backend.dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

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



app.MapGet("/", () => "c# one of the best things out there mate");

app.Run();
