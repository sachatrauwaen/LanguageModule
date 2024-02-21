import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'LanguageModule',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44319/',
    redirectUri: baseUrl,
    clientId: 'LanguageModule_App',
    responseType: 'code',
    scope: 'offline_access LanguageModule',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44319',
      rootNamespace: 'Satrabel.LanguageModule',
    },
    LanguageModule: {
      url: 'https://localhost:44352',
      rootNamespace: 'Satrabel.LanguageModule',
    },
  },
} as Environment;
