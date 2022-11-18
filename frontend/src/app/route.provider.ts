import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/airtracking',
        name: '::Menu:AirTracking',
        iconClass: 'fas fa-plane-departure',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/shipments',
        name: '::Menu:Shipments',
        parentName: '::Menu:AirTracking',
        layout: eLayoutType.application,
      },
      {
        path: '/attendance',
        name: '::Menu:Employees',
        iconClass: 'fas fa-users',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/departments',
        name: '::Menu:Departments',
        parentName: '::Menu:Employees',
        layout: eLayoutType.application,
      },
    ]);
  };
}
