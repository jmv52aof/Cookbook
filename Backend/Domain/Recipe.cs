namespace Cookbook.Domain;

public class Recipe
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string ShortDescription { get; private set; }
    public int CookTimeMinutes { get; private set; }
    public int Portions { get; private set; }

    public Recipe( int id, string name, string shortDescription, int cookTimeMinutes, int portions )
    {
        Id = id;
        Name = name;
        ShortDescription = shortDescription;
        CookTimeMinutes = cookTimeMinutes;
        Portions = portions;
    }
}
