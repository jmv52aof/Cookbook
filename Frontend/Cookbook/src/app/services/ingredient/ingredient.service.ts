import { Injectable } from '@angular/core';
import { IIngridient } from '../../models/ingridient.interface';
import { Observable } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class IngredientService {
  private readonly apiUrl: string = 'http://localhost:5177';

  constructor(private httpClient: HttpClient) {
  }

  public getAllByRecipeId( recipeId: number ): Observable<IIngridient[]> {
    return this.httpClient.get<IIngridient[]>(`${this.apiUrl}/ingridient/${recipeId}`);
  }

  public add( ingridient: IIngridient ): Observable<any> {
    let request = `${this.apiUrl}/ingridient/add`;
    let token = sessionStorage.getItem( 'token' ) ?? ""
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      "Authorization": "Bearer " + token
    });
    return this.httpClient.post<IIngridient>( request, ingridient, { headers } );
  }
}
