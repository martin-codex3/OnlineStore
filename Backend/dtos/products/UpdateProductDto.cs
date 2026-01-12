namespace Backend.dtos.products;

public record class UpdateProductDto (
    string ProductTitle,
    string ProductDescription,
    string ProductCategory,
    decimal ProductPrice,
    bool IsComplete,
    DateOnly CreatedAt,
    DateOnly UpdatedAt
);