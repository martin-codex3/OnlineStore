using System;

namespace Backend.models.Categories;

public class CategoryModel
{
    public int Id {get; set;}
    public required string CategoryTitle { get; set; }
    public required string CategoryDescription { get; set; }
    public required DateOnly CreatedAt { get; set; }
    public required DateOnly UpdatetdAt { get; set; }
}
