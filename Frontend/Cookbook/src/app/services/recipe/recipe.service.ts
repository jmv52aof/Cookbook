import { Injectable } from '@angular/core';
import { IRecipe } from '../../models/recipe.interface';
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class RecipeService {
  private readonly apiUrl: string = 'http://localhost:5177';

  constructor(private httpClient: HttpClient) {
  }

  public getAll(): Observable<IRecipe[]> {
    return this.httpClient.get<IRecipe[]>(`${this.apiUrl}/recipe`);
  }

  public getById( id: number ): Observable<IRecipe> {
    return this.httpClient.get<IRecipe>(`${this.apiUrl}/recipe/${id}`);
  }
}
