import { Injectable } from '@angular/core';
import { IAccount } from '../../models/account.interface';
import { Observable } from "rxjs";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class AccountService {
  private readonly apiUrl: string = 'http://localhost:5177';

  constructor(private httpClient: HttpClient) {
  }

  public getToken( login: string, password: string ): Observable<any> {
    return this.httpClient.get<any>(`${this.apiUrl}/token/${login}/${password}`);
  }

  public addAccount( account: IAccount ): Observable<any> {
    let request = `${this.apiUrl}/account/add/${account.name}/${account.login}/${account.password}`;
    return this.httpClient.get( request );
  }

  public getAccount( token: string, login: string ): Observable<IAccount> {
    let request = `${this.apiUrl}/account/get/${login}`;
    const headers = new HttpHeaders({
      "Authorization": "Bearer " + token
    });
    return this.httpClient.get<IAccount>( request, { headers } );
  }
}
