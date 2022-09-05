namespace Cookbook.Dto;

using Cookbook.Domain;

public static class RecipeDtoExtension
{
    public static Recipe ConvertToRecipe( this RecipeDto recipeDto )
    {
        return new Recipe(
            recipeDto.Id,
            recipeDto.Name ?? "",
            recipeDto.ShortDescription ?? "",
            recipeDto.CookTimeMinutes,
            recipeDto.Portions
        );
    }

    public static RecipeDto ConvertToRecipeDto( this Recipe recipe )
    {
        return new RecipeDto
        {
            Id = recipe.Id,
            Name = recipe.Name ?? "",
            ShortDescription = recipe.ShortDescription ?? "",
            CookTimeMinutes = recipe.CookTimeMinutes,
            Portions = recipe.Portions
        };
    }
}
