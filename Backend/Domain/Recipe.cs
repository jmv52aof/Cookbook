namespace Cookbook.Domain;

public class Recipe
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string ShortDescription { get; private set; }
    public string FullDescription { get; private set; }

    public Recipe( int id, string name, string shortDescription, string fullDescription )
    {
        Id = id;
        Name = name;
        ShortDescription = shortDescription;
        FullDescription = fullDescription;
    }
}
