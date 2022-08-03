import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipesPageComponent } from './recipes-page/recipes-page.component';
import { DetailedRecipePageComponent } from './detailed-recipe-page/detailed-recipe-page.component';

const routes: Routes = [
    { path: 'recipes', component: RecipesPageComponent },
    { path: 'recipe', component: DetailedRecipePageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
