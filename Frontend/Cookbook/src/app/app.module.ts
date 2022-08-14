import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RecipesPageComponent } from './components/recipes-page/recipes-page.component';
import { RecipeComponent } from './components/recipe/recipe.component';
import { DetailedRecipePageComponent } from './components/detailed-recipe-page/detailed-recipe-page.component';
import { RecipeService } from './services/recipe/recipe.service';
import { HttpClientModule } from '@angular/common/http';
import { MatCardModule } from '@angular/material/card';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatFormFieldModule } from '@angular/material/form-field';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { MainPageComponent } from './components/main-page/main-page.component';
import { DialogRegistrationComponent } from './components/dialog-registration/dialog-registration.component';
import { FormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import { DialogAuthorizationComponent } from './components/dialog-authorization/dialog-authorization.component';
import { DialogAuthChooseComponent } from './components/dialog-auth-choose/dialog-auth-choose.component';

@NgModule({
  declarations: [
    AppComponent,
    RecipesPageComponent,
    RecipeComponent,
    DetailedRecipePageComponent,
    HeaderComponent,
    FooterComponent,
    MainPageComponent,
    DialogRegistrationComponent,
    DialogAuthorizationComponent,
    DialogAuthChooseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatCardModule,
    MatProgressBarModule,
    MatButtonModule,
    MatDialogModule,
    MatFormFieldModule,
    FormsModule,
    MatInputModule
  ],
  providers: [
    RecipeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
