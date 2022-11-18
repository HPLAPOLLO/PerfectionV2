import type { ShipmentDto } from './models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ShipmentService {
  apiName = 'Default';
  

  getList = () =>
    this.restService.request<any, ShipmentDto[]>({
      method: 'GET',
      url: '/api/app/shipment',
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
