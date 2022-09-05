import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RecipesPageComponent } from './components/recipes-page/recipes-page.component';
import { DetailedRecipePageComponent } from './components/detailed-recipe-page/detailed-recipe-page.component';
import { MainPageComponent } from './components/main-page/main-page.component';
import { AddRecipePageComponent } from './components/add-recipe-page/add-recipe-page.component';

const routes: Routes = [
    { path: 'recipes', component: RecipesPageComponent },
    { path: 'recipe', component: DetailedRecipePageComponent },
    { path: 'main', component: MainPageComponent },
    { path: 'add-recipe', component: AddRecipePageComponent },
    { path: '**', redirectTo: 'main' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
