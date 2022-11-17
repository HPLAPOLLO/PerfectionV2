import type { AuditedEntityDto } from '@abp/ng.core';

export interface ShipmentDto extends AuditedEntityDto<string> {
  branch?: string;
  origin?: string;
  destination?: string;
  shipmentId?: string;
  airwayBillNumber?: string;
  carrierCode?: string;
  ohCode?: string;
  legOrder: number;
  flight?: string;
  loadPort?: string;
  etd?: string;
  eta?: string;
  ata?: string;
  atdCt: number;
  ataCt: number;
  jwAtd?: string;
  dischargePort?: string;
  isLinked: boolean;
}
