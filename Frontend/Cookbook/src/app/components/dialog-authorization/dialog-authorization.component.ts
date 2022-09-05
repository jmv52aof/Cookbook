import { Component, OnInit } from '@angular/core';
import { retry, delay } from "rxjs/operators";
import { MatDialog } from '@angular/material/dialog';
import { DialogRegistrationComponent } from '../dialog-registration/dialog-registration.component';
import { AccountService } from '../../services/account/account.service';

@Component({
  selector: 'dialog-authorization',
  templateUrl: './dialog-authorization.component.html',
  styleUrls: ['./dialog-authorization.component.scss']
})
export class DialogAuthorizationComponent implements OnInit {
  constructor(
    private dialog: MatDialog,
    private accountService: AccountService
  ) { }

  login: string;
  password: string;

  ngOnInit(): void {
  }

  openRegistrationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogRegistrationComponent);
  }

  getUser() {
    this.accountService.getToken( this.login, this.password ).pipe(
      retry(3),
      delay(1000)
    ).subscribe( 
      item => sessionStorage.setItem( 'token', item.token ) 
    );
    this.accountService.getAccount( sessionStorage.getItem( 'token' ) ?? "", this.login ).pipe(
      retry(3),
      delay(1000)
    ).subscribe( item =>
      sessionStorage.setItem('name', item.name )
    );
    this.dialog.closeAll();
  }
}

// TODO: Parameters in config
