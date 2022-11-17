import type { ShipmentDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ShipmentService {
  apiName = 'Default';
  

  create = (input: ShipmentDto) =>
    this.restService.request<any, ShipmentDto>({
      method: 'POST',
      url: '/api/app/shipment',
      body: input,
    },
    { apiName: this.apiName });
  

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/shipment/${id}`,
    },
    { apiName: this.apiName });
  

  get = (id: string) =>
    this.restService.request<any, ShipmentDto>({
      method: 'GET',
      url: `/api/app/shipment/${id}`,
    },
    { apiName: this.apiName });
  

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ShipmentDto>>({
      method: 'GET',
      url: '/api/app/shipment',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });
  

  update = (id: string, input: ShipmentDto) =>
    this.restService.request<any, ShipmentDto>({
      method: 'PUT',
      url: `/api/app/shipment/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
