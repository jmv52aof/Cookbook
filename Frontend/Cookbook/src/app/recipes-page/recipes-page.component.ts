import { Component, OnInit } from '@angular/core';
import { RecipeService } from "../shared/recipe.service";
import { IRecipe } from "../shared/recipe.interface";

@Component({
  selector: 'recipes-page',
  templateUrl: './recipes-page.component.html',
  styleUrls: ['./recipes-page.component.scss'],
  providers: [RecipeService]
})
export class RecipesPageComponent implements OnInit {
  public recipes: IRecipe[];

  constructor(private recipeService: RecipeService) {
    this.loadRecipes();
    console.log(this.recipes);
  }

  ngOnInit(): void {
  }

  public loadRecipes(): void {
    this.recipeService.getAll().subscribe(items => {
        this.recipes = items;
    })
  }

}
