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

  shipment = { items: [], totalCount: 0 } as PagedResultDto<ShipmentDto>;

  constructor(public readonly list: ListService, private shipmentService: ShipmentService) { }

  ngOnInit() {

    const shipmentStreamCreator = (query) => this.shipmentService.getList(query);

    this.list.hookToQuery(shipmentStreamCreator).subscribe((response) => {
      this.shipment = response;
    });
  }

}
