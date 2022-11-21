import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ShipmentRoutingModule } from './shipment-routing.module';
import { ShipmentComponent } from './shipment.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ShipmentFormatPipe } from 'src/app/shared/pipes/shipment-format.pipe';

@NgModule({
  declarations: [
    ShipmentComponent,
    ShipmentFormatPipe
  ],
  imports: [
    CommonModule,
    ShipmentRoutingModule,
    SharedModule
  ]
})
export class ShipmentModule { }
