import type { HouseShipmentDto } from './models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class HouseShipmentService {
  apiName = 'Default';
  

  getList = () =>
    this.restService.request<any, HouseShipmentDto[]>({
      method: 'GET',
      url: '/api/app/house-shipment',
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
