import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Server',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44391/',
    redirectUri: baseUrl,
    clientId: 'Server_App',
    responseType: 'code',
    scope: 'offline_access Server',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44391',
      rootNamespace: 'Hpl.Server',
    },
  },
} as Environment;
