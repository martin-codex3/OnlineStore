using System;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public static class AutoMigrations
{
    // we will run the auto migrations here
    public static void runMigrations(this WebApplication app)
    {
        // we first have to create the scope for the migrations here
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        // then we will run the migrations here
        dbContext.Database.Migrate();
    }
}
