import { Component, OnInit } from '@angular/core';
import { RecipeService } from "../../services/recipe/recipe.service";
import { IngredientService } from "../../services/ingredient/ingredient.service";
import { StepService } from "../../services/step/step.service";
import { IRecipe } from "../../models/recipe.interface";
import { IStep } from "../../models/step.interface";
import { IIngridient } from "../../models/ingridient.interface";
import { ActivatedRoute } from '@angular/router';
import { EventEmitter, Input, Output } from "@angular/core";
import { Location } from "@angular/common";

@Component({
  selector: 'detailed-recipe-page',
  templateUrl: './detailed-recipe-page.component.html',
  styleUrls: ['./detailed-recipe-page.component.scss']
})
export class DetailedRecipePageComponent {

  @Input() public recipe: IRecipe;
  @Input() public steps: IStep[];
  @Input() public ingridients: IIngridient[];
  @Output() public back: EventEmitter<IRecipe> = new EventEmitter<IRecipe>();

  constructor(
    private recipeService: RecipeService,
    private stepService: StepService,
    private ingridientService: IngredientService,
    private route: ActivatedRoute,
    private location: Location
  ) {

  }

  ngOnInit(): void {
    this.route.queryParams
      .subscribe(params => {
        this.recipeService.getById( params['id'] ).subscribe(item => {
          this.recipe = item;
        });
        this.ingridientService.getAllByRecipeId( params['id'] ).subscribe(items => {
          this.ingridients = items;
        });
        this.stepService.getAllByRecipeId( params['id'] ).subscribe(items => {
          this.steps = items;
        });
      }
    );
  }

  public backClicked(): void {
    this.location.back();
    this.back.emit(this.recipe);
  }
}
