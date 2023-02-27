import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageRequesttypeComponent } from './manage-requesttype.component';

describe('ManageRequesttypeComponent', () => {
  let component: ManageRequesttypeComponent;
  let fixture: ComponentFixture<ManageRequesttypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManageRequesttypeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageRequesttypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
