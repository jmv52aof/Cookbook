import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogRegistrationComponent } from '../dialog-registration/dialog-registration.component';
import { DialogAuthorizationComponent } from '../dialog-authorization/dialog-authorization.component';

@Component({
  selector: 'dialog-auth-choose',
  templateUrl: './dialog-auth-choose.component.html',
  styleUrls: ['./dialog-auth-choose.component.scss']
})
export class DialogAuthChooseComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openAuthorizationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogAuthorizationComponent);
  }

  openRegistrationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogRegistrationComponent);
  }
}
