import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DialogAuthorizationComponent } from '../dialog-authorization/dialog-authorization.component';

@Component({
  selector: 'header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {

  }

  openAuthorizationDialog() {
    this.dialog.closeAll();
    this.dialog.open(DialogAuthorizationComponent);
  }

  getName() {
    return sessionStorage.getItem('name') ?? '';
  }

  exit() {
    sessionStorage.setItem('name', '');
    sessionStorage.setItem('token', '');
  }
}
