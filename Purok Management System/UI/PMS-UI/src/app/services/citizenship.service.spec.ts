import { TestBed } from '@angular/core/testing';

import { CitizenshipService } from './citizenship.service';

describe('CitizenshipService', () => {
  let service: CitizenshipService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CitizenshipService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
