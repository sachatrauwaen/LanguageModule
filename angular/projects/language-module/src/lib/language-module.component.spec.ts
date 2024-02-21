import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { LanguageModuleComponent } from './components/language-module.component';
import { LanguageModuleService } from '@satrabel/language-module';
import { of } from 'rxjs';

describe('LanguageModuleComponent', () => {
  let component: LanguageModuleComponent;
  let fixture: ComponentFixture<LanguageModuleComponent>;
  const mockLanguageModuleService = jasmine.createSpyObj('LanguageModuleService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [LanguageModuleComponent],
      providers: [
        {
          provide: LanguageModuleService,
          useValue: mockLanguageModuleService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LanguageModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
