import { TestBed } from '@angular/core/testing';

import { CivilstatusService } from './civilstatus.service';

describe('CivilstatusService', () => {
  let service: CivilstatusService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CivilstatusService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
