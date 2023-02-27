import { TestBed } from '@angular/core/testing';

import { PuroksitioService } from './puroksitio.service';

describe('PuroksitioService', () => {
  let service: PuroksitioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PuroksitioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
