namespace Backend.dtos.products;

public record class ProductDto (
    int ProductId,
    string ProductTitle,
    string ProductDescription,
    string ProductCategory,
    decimal ProductPrice,
    bool IsComplete,
    DateOnly CreatedAt,
    DateOnly UpdatedAt
);
