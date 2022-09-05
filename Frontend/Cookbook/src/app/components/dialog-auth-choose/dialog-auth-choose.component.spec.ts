import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogAuthChooseComponent } from './dialog-auth-choose.component';

describe('DialogAuthChooseComponent', () => {
  let component: DialogAuthChooseComponent;
  let fixture: ComponentFixture<DialogAuthChooseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DialogAuthChooseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DialogAuthChooseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
