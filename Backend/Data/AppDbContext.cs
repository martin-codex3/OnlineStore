using System;
using Backend.models.Categories;
using Backend.models.Products;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    // we will create the database tables here
    public DbSet<CategoryModel> categories => Set<CategoryModel>();
    public DbSet<ProductModel> products => Set<ProductModel>();
}
