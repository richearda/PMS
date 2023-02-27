import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestBarangayClearanceComponent } from './request-barangay-clearance.component';

describe('RequestBarangayClearanceComponent', () => {
  let component: RequestBarangayClearanceComponent;
  let fixture: ComponentFixture<RequestBarangayClearanceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RequestBarangayClearanceComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RequestBarangayClearanceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
