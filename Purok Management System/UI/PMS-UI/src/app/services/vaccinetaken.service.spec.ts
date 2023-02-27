import { TestBed } from '@angular/core/testing';

import { VaccinetakenService } from './vaccinetaken.service';

describe('VaccinetakenService', () => {
  let service: VaccinetakenService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VaccinetakenService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
