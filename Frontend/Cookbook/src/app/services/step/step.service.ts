import { Injectable } from '@angular/core';
import { IStep } from '../../models/step.interface';
import { Observable } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class StepService {
  private readonly apiUrl: string = 'http://localhost:5177';

  constructor(private httpClient: HttpClient) {
  }

  public getAllByRecipeId( stepId: number ): Observable<IStep[]> {
    return this.httpClient.get<IStep[]>(`${this.apiUrl}/step/${stepId}`);
  }

  public add( step: IStep ): Observable<any> {
    let request = `${this.apiUrl}/step/add`;
    let token = sessionStorage.getItem( 'token' ) ?? ""
    const headers = new HttpHeaders({
      'Content-Type':  'application/json',
      "Authorization": "Bearer " + token
    });
    return this.httpClient.post<IStep>( request, step, { headers } );
  }
}
