namespace Cookbook.Dto;

using Cookbook.Domain;

public static class IngridientDtoExtension
{
    public static Ingridient ConvertToIngridient( this IngridientDto ingridientDto )
    {
        return new Ingridient(
            ingridientDto.Id,
            ingridientDto.Title ?? "",
            ingridientDto.Text ?? "",
            ingridientDto.RecipeId
        );
    }

    public static IngridientDto ConvertToIngridientDto( this Ingridient ingridient )
    {
        return new IngridientDto
        {
            Id = ingridient.Id,
            Title = ingridient.Title,
            Text = ingridient.Text,
            RecipeId = ingridient.RecipeId
        };
    }
}
