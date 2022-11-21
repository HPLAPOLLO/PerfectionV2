import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'shipmentformat' })
export class ShipmentFormatPipe implements PipeTransform {

  constructor() { }

  transform(shipment: string) {

    if (!shipment) return;

    const digits = [...shipment];

    const result = `${digits.slice(0, 3).join('')}-${digits.slice(3, 7).join('')}-${digits.slice(7, 11).join('')}`

    return result;
  }
}
