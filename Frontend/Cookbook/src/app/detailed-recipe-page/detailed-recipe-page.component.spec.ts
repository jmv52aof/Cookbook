import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedRecipePageComponent } from './detailed-recipe-page.component';

describe('DetailedRecipePageComponent', () => {
  let component: DetailedRecipePageComponent;
  let fixture: ComponentFixture<DetailedRecipePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailedRecipePageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetailedRecipePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
