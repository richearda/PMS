import { TestBed } from '@angular/core/testing';

import { BloodtypeService } from './bloodtype.service';

describe('BloodtypeService', () => {
  let service: BloodtypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BloodtypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
