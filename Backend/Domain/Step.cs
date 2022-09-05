namespace Cookbook.Domain;

public class Step
{
    public int Id { get; private set; }
    public string Text { get; private set; }
    public int RecipeId { get; private set; }

    public Step( int id, string text, int recipeId )
    {
        Id = id;
        Text = text;
        RecipeId = recipeId;
    }
}
