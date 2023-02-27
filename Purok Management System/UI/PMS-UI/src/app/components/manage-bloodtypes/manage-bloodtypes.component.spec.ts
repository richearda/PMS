import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageBloodtypesComponent } from './manage-bloodtypes.component';

describe('ManageBloodtypesComponent', () => {
  let component: ManageBloodtypesComponent;
  let fixture: ComponentFixture<ManageBloodtypesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManageBloodtypesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageBloodtypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
