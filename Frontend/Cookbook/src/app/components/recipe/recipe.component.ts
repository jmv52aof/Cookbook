import { Component, EventEmitter, Input, Output } from "@angular/core";
import { IRecipe } from "../../models/recipe.interface";
import { Router } from '@angular/router';

@Component({
  selector: 'recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.scss']
})

export class RecipeComponent {
  @Input() public item: IRecipe;
  @Output() public more: EventEmitter<IRecipe> = new EventEmitter<IRecipe>();

  constructor(private router: Router) {}

  public moreClicked(): void {
    this.goDetailedRecipe(this.item.id);
    this.more.emit(this.item);
  }

  public goDetailedRecipe( itemId: number ): void {
    this.router.navigate(
      ['/recipe'],
      { queryParams: { id: itemId } }
    );
  }
}
