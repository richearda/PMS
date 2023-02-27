import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestBarangayIdComponent } from './request-barangay-id.component';

describe('RequestBarangayIdComponent', () => {
  let component: RequestBarangayIdComponent;
  let fixture: ComponentFixture<RequestBarangayIdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RequestBarangayIdComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RequestBarangayIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
