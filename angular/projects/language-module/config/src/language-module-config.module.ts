import { ModuleWithProviders, NgModule } from '@angular/core';
import { LANGUAGE_MODULE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class LanguageModuleConfigModule {
  static forRoot(): ModuleWithProviders<LanguageModuleConfigModule> {
    return {
      ngModule: LanguageModuleConfigModule,
      providers: [LANGUAGE_MODULE_ROUTE_PROVIDERS],
    };
  }
}
