/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PraticienService } from './praticien.service';

describe('Service: Praticien', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PraticienService]
    });
  });

  it('should ...', inject([PraticienService], (service: PraticienService) => {
    expect(service).toBeTruthy();
  }));
});
