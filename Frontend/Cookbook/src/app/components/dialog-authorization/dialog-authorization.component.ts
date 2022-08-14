import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogRegistrationComponent } from '../dialog-registration/dialog-registration.component';

@Component({
  selector: 'dialog-authorization',
  templateUrl: './dialog-authorization.component.html',
  styleUrls: ['./dialog-authorization.component.scss']
})
export class DialogAuthorizationComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openRegistrationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogRegistrationComponent);
  }
}
