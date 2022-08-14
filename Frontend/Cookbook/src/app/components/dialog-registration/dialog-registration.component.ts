import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogAuthorizationComponent } from '../dialog-authorization/dialog-authorization.component';

@Component({
  selector: 'dialog-registration',
  templateUrl: './dialog-registration.component.html',
  styleUrls: ['./dialog-registration.component.scss']
})
export class DialogRegistrationComponent implements OnInit {
  public test: Event;
  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }

  openAuthorizationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogAuthorizationComponent);
  }
}
