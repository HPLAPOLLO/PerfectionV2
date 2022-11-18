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
        path: '/tracking',
        name: '::Menu:Tracking',
        iconClass: 'fas fa-plane-departure',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/shipments',
        name: '::Menu:Shipments',
        parentName: '::Menu:Tracking',
        layout: eLayoutType.application,
      },
      {
        path: '/attendance',
        name: '::Menu:Attendance',
        iconClass: 'fas fa-book',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/departments',
        name: '::Menu:Departments',
        parentName: '::Menu:Attendance',
        layout: eLayoutType.application,
      },
    ]);
  };
}
