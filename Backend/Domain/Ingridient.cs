namespace Cookbook.Domain;

public class Ingridient
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Text { get; private set; }
    public int RecipeId { get; private set; }

    public Ingridient( int id, string title, string text, int recipeId )
    {
        Id = id;
        Title = title;
        Text = text;
        RecipeId = recipeId;
    }
}
