import { TestBed } from '@angular/core/testing';

import { HealthbackgroundService } from './healthbackground.service';

describe('HealthbackgroundService', () => {
  let service: HealthbackgroundService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HealthbackgroundService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
