var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/recipes", () =>
{
    return Results.Ok(RecipeCatalog.Recipes);
});

app.MapGet("/api/recipes/{id:int}", (int id) =>
{
    var recipe = RecipeCatalog.Recipes
        .FirstOrDefault(recipe => recipe.Id == id);

    return recipe is null
        ? Results.NotFound()
        : Results.Ok(recipe);
});

app.MapGet("/api/categories", () =>
{
    var categories = RecipeCatalog.Recipes
        .Select(recipe => recipe.Category)
        .Distinct()
        .OrderBy(category => category)
        .ToArray();

    return Results.Ok(categories);
});

app.Run();