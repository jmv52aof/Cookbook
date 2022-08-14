import { Component, OnInit } from '@angular/core';
import { RecipeService } from "../../services/recipe/recipe.service";
import { IRecipe } from "../../models/recipe.interface";
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
  @Output() public back: EventEmitter<IRecipe> = new EventEmitter<IRecipe>();

  constructor(private recipeService: RecipeService, private route: ActivatedRoute, private location: Location)
  {
  }

  ngOnInit(): void {
    this.route.queryParams
      .subscribe(params => {
        this.recipeService.getById( params['id'] ).subscribe(item => {
          this.recipe = item;
        });
      }
    );
  }

  public backClicked(): void {
    this.location.back();
    this.back.emit(this.recipe);
  }
}
