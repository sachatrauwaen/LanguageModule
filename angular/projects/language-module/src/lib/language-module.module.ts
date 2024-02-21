import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { LanguageModuleComponent } from './components/language-module.component';
import { LanguageModuleRoutingModule } from './language-module-routing.module';

@NgModule({
  declarations: [LanguageModuleComponent],
  imports: [CoreModule, ThemeSharedModule, LanguageModuleRoutingModule],
  exports: [LanguageModuleComponent],
})
export class LanguageModuleModule {
  static forChild(): ModuleWithProviders<LanguageModuleModule> {
    return {
      ngModule: LanguageModuleModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<LanguageModuleModule> {
    return new LazyModuleFactory(LanguageModuleModule.forChild());
  }
}
