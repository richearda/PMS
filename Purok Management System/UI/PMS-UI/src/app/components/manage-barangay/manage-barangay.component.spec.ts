import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManageBarangayComponent } from './manage-barangay.component';

describe('ManageBarangayComponent', () => {
  let component: ManageBarangayComponent;
  let fixture: ComponentFixture<ManageBarangayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManageBarangayComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManageBarangayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
