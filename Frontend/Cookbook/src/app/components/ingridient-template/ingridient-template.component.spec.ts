import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IngridientTemplateComponent } from './ingridient-template.component';

describe('IngridientTemplateComponent', () => {
  let component: IngridientTemplateComponent;
  let fixture: ComponentFixture<IngridientTemplateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IngridientTemplateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(IngridientTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
