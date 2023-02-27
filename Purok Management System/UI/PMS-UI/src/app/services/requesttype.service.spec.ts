import { TestBed } from '@angular/core/testing';

import { RequesttypeService } from './requesttype.service';

describe('RequesttypeService', () => {
  let service: RequesttypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RequesttypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
