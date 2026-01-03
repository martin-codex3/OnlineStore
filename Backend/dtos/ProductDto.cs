namespace Backend.dtos;

public record class ProductDto (
    string ProductTitle,
    string ProductDescription,
    string ProductCategory,
    float ProductPrice,
    bool IsComplete,
    DateOnly CreatedAt,
    DateOnly UpdatedAt
);
