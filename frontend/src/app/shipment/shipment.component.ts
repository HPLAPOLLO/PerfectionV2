import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { ShipmentDto, ShipmentService } from '@proxy/shipments';

@Component({
  selector: 'app-shipment',
  templateUrl: './shipment.component.html',
  styleUrls: ['./shipment.component.scss'],
  providers: [ListService]
})
export class ShipmentComponent implements OnInit {

  shipment: ShipmentDto[];

  constructor(private shipmentService: ShipmentService) { }

  ngOnInit() {

    this.shipmentService.getList().subscribe((response) => {
      this.shipment = response;

      console.log(response);
    });
  }

}
