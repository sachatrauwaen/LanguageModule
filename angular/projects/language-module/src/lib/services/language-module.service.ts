import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class LanguageModuleService {
  apiName = 'LanguageModule';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/LanguageModule/sample' },
      { apiName: this.apiName }
    );
  }
}
