import { Component, OnInit } from '@angular/core';
import { RecipeService } from "../../services/recipe/recipe.service";
import { IngredientService } from "../../services/ingredient/ingredient.service";
import { StepService } from "../../services/step/step.service";
import { IRecipe } from "../../models/recipe.interface";
import { IIngridient } from "../../models/ingridient.interface";
import { IStep } from "../../models/step.interface";
import { ActivatedRoute } from '@angular/router';
import { EventEmitter, Input, Output } from "@angular/core";
import { Location } from "@angular/common";

@Component({
  templateUrl: './add-recipe-page.component.html',
  styleUrls: ['./add-recipe-page.component.scss']
})
export class AddRecipePageComponent {

  @Input() public recipe: IRecipe;
  @Input() public ingridients: IIngridient[];
  @Input() public steps: IStep[];
  @Output() public back: EventEmitter<IRecipe> = new EventEmitter<IRecipe>();

  constructor(
    private recipeService: RecipeService,
    private ingredientService: IngredientService,
    private stepService: StepService,
    private route: ActivatedRoute,
    private location: Location
  ) {

  }

  ngOnInit(): void {
    this.ingridients = [];
    this.steps = [];
    this.recipe = {} as IRecipe;

    this.addIngridient();
    this.addStep();

    this.recipe.cookTimeMinutes = 10;
    this.recipe.portions = 1;
  }

  public backClicked(): void {
    this.location.back();
    this.back.emit(this.recipe);
  }

  public addIngridient(): void {
    let ingridient = {} as IIngridient;
    ingridient.id = 0;
    ingridient.title = "";
    ingridient.text = "";
    ingridient.recipeId = 0;
    this.ingridients.push(ingridient);
  }

  public addStep(): void {
    let step = {} as IStep;
    step.id = 0;
    step.text = "";
    step.recipeId = 0;
    this.steps.push(step);
  }

  public deleteIngridient(ingridient: IIngridient): void {
    this.ingridients = this.ingridients.filter( item => item != ingridient );
  }

  public deleteStep(step: IStep): void {
    this.steps = this.steps.filter( item => item != step );
  }

  public publishRecipe(recipe: IRecipe): void {
    let id = 0;
    this.recipeService.add( recipe ).subscribe( item => {
      id = item;
      this.ingridients.forEach( item => {
        item.recipeId = id;
        this.ingredientService.add( item ).subscribe();
      });
      this.steps.forEach( item => {
        item.recipeId = id;
        this.stepService.add( item ).subscribe();
      });
    });
  }
}
