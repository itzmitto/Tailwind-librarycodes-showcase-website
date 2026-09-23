public static class RecipeCatalog
{
    public static IReadOnlyList<Recipe> Recipes { get; } =
        RecipeData.Recipes
            .Concat(InteractiveRecipeData.Recipes)
            .OrderBy(recipe => recipe.Id)
            .ToArray();
}