import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ShipmentRoutingModule } from './shipment-routing.module';
import { ShipmentComponent } from './shipment.component';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [
    ShipmentComponent
  ],
  imports: [
    CommonModule,
    ShipmentRoutingModule,
    SharedModule
  ]
})
export class ShipmentModule { }
