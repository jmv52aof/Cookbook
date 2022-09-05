namespace Cookbook.Dto;

public class RecipeDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ShortDescription { get; set; }
    public int CookTimeMinutes { get; set; }
    public int Portions { get; set; }
}
