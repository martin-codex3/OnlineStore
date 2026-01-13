using System.ComponentModel.DataAnnotations;

namespace Backend.dtos.products;

public record class UpdateProductDto (
    [Required]
    string ProductTitle,

    [Required]
    string ProductDescription,

    [Required]
    string ProductCategory,

    [Required]
    decimal ProductPrice,

    [Required]
    bool IsComplete,

    DateOnly CreatedAt,
    DateOnly UpdatedAt
);