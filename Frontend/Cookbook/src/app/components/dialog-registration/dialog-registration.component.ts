import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogAuthorizationComponent } from '../dialog-authorization/dialog-authorization.component';
import { AccountService } from '../../services/account/account.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { IAccount } from '../../models/account.interface';

@Component({
  templateUrl: './dialog-registration.component.html',
  styleUrls: ['./dialog-registration.component.scss'],
  providers: [AccountService]
})
export class DialogRegistrationComponent implements OnInit {
  constructor(
    private dialog: MatDialog,
    private _snackBar: MatSnackBar,
    private accountService: AccountService
  ) { }

  newAccount: IAccount;
  repeatedPassword: string;

  ngOnInit(): void {
    this.newAccount = {} as IAccount;
    this.newAccount.password = '';
    this.repeatedPassword = '';
  }

  openAuthorizationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogAuthorizationComponent);
  }

  addUser() {
    if ( this.newAccount.password.length < 8 ) {
      this.showAlert("Пароль должен содержать 8 символов или больше");
      return;
    }
    if ( this.newAccount.password != this.repeatedPassword ) {
      this.showAlert("Пароли не совпадают");
      return;
    }
    if ( !this.newAccount.login ) {
      this.showAlert("Логин не может быть пустым");
      return;
    }

    this.accountService.addAccount( this.newAccount ).subscribe();
    this.dialog.closeAll();
  }

  private showAlert(message: string) {
    this._snackBar.open(message, 'OK', {
      horizontalPosition: 'center',
      verticalPosition: 'top',
      duration: 10 * 1000
    });
  }
}
