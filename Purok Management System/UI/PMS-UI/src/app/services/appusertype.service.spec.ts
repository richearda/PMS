import { TestBed } from '@angular/core/testing';

import { AppusertypeService } from './appusertype.service';

describe('AppusertypeService', () => {
  let service: AppusertypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AppusertypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
