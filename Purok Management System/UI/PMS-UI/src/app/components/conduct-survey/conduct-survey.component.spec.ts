import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConductSurveyComponent } from './conduct-survey.component';

describe('ConductSurveyComponent', () => {
  let component: ConductSurveyComponent;
  let fixture: ComponentFixture<ConductSurveyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ConductSurveyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConductSurveyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
