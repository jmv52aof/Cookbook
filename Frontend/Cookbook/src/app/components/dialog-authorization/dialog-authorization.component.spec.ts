import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogAuthorizationComponent } from './dialog-authorization.component';

describe('DialogAuthorizationComponent', () => {
  let component: DialogAuthorizationComponent;
  let fixture: ComponentFixture<DialogAuthorizationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogAuthorizationComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DialogAuthorizationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
