using System;
using Backend.models.Categories;

namespace Backend.models.Products;

public class ProductModel
{
    public int ProductId {get; set;}
    public required string ProductTitle { get; set; }
    public required string ProductDescription { get; set; }
    public CategoryModel? Category {get; set;}
    public int CategoryId {get; set;}
    public required decimal ProductPrice { get; set; }
    public required bool IsComplete { get; set; }
    public required DateOnly CreatedAt { get; set; }
    public required DateOnly UpdatedAt { get; set; }
}
