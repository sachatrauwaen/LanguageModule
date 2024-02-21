import { TestBed } from '@angular/core/testing';
import { LanguageModuleService } from './services/language-module.service';
import { RestService } from '@abp/ng.core';

describe('LanguageModuleService', () => {
  let service: LanguageModuleService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(LanguageModuleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
