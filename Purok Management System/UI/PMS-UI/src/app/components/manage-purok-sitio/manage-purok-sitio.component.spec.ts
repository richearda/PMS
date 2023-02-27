import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagePurokSitioComponent } from './manage-purok-sitio.component';

describe('ManagePurokSitioComponent', () => {
  let component: ManagePurokSitioComponent;
  let fixture: ComponentFixture<ManagePurokSitioComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManagePurokSitioComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagePurokSitioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
