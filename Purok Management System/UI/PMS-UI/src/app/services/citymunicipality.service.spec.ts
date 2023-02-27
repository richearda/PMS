import { TestBed } from '@angular/core/testing';

import { CityMunicipalityService } from './citymunicipality.service';

describe('CitymunicipalityService', () => {
  let service: CityMunicipalityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CityMunicipalityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
