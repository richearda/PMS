import { TestBed } from '@angular/core/testing';

import { PreexistingconditionService } from './preexistingcondition.service';

describe('PreexistingconditionService', () => {
  let service: PreexistingconditionService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PreexistingconditionService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
