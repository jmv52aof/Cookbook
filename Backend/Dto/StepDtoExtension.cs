namespace Cookbook.Dto;

using Cookbook.Domain;

public static class StepDtoExtension
{
    public static Step ConvertToStep( this StepDto stepDto )
    {
        return new Step(
            stepDto.Id,
            stepDto.Text ?? "",
            stepDto.RecipeId
        );
    }

    public static StepDto ConvertToStepDto( this Step step )
    {
        return new StepDto
        {
            Id = step.Id,
            Text = step.Text,
            RecipeId = step.RecipeId
        };
    }
}
