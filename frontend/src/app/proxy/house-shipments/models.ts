import type { AuditedEntityDto } from '@abp/ng.core';

export interface HouseShipmentDto extends AuditedEntityDto<string> {
  containerNumber?: string;
  grossWeight?: number;
  grossWeightUq?: string;
  consolidationNumber?: string;
  airwaybillNumber?: string;
  shipmentType?: string;
  origin?: string;
  destination?: string;
  dischargePort?: string;
  legOrder?: number;
  etd?: string;
  atd?: string;
  ata?: string;
  shipmentNumber?: string;
  packs?: number;
  packUom?: string;
  actualWeight?: number;
  unitOfWeight?: string;
  shipper?: string;
  consigneeCode?: string;
  consignee?: string;
  client?: string;
  clientCode?: string;
}
