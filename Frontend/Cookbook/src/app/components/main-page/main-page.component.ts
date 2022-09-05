import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogRegistrationComponent } from '../dialog-registration/dialog-registration.component';
import { DialogAuthorizationComponent } from '../dialog-authorization/dialog-authorization.component';
import { DialogAuthChooseComponent } from '../dialog-auth-choose/dialog-auth-choose.component';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent {

  constructor(public dialog: MatDialog) { }

  openAuthDialog() {
    this.dialog.open(DialogAuthorizationComponent);
  }

  openChooseAuthDialog() {
    this.dialog.open(DialogAuthChooseComponent);
  }

  ngOnInit(): void {
  }

}
