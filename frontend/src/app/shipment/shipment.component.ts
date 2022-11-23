import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { ShipmentDto, ShipmentService } from '@proxy/shipments';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { PrimeIcons } from 'primeng/api';

@Component({
  selector: 'app-shipment',
  templateUrl: './shipment.component.html',
  styleUrls: ['./shipment.component.scss'],
  providers: [ListService],
  animations: [
    trigger('rowExpansionTrigger', [
        state('void', style({
            transform: 'translateX(-10%)',
            opacity: 0
        })),
        state('active', style({
            transform: 'translateX(0)',
            opacity: 1
        })),
        transition('* <=> *', animate('400ms cubic-bezier(0.86, 0, 0.07, 1)'))
    ])
]
})
export class ShipmentComponent implements OnInit {

  shipment: ShipmentDto[];
  // events: any[];

  constructor(private shipmentService: ShipmentService) { }

  ngOnInit() {

  //   this.events = [
  //     {status: 'Recieved',icon: PrimeIcons.CHECK , color: "#6495ED", iconCircle: PrimeIcons.CIRCLE},
  //     {status: 'In transit',icon: PrimeIcons.CHECK, color: "#6495ED", iconCircle: PrimeIcons.CIRCLE},
  //     {status: 'Arrived',icon: PrimeIcons.CHECK, color: '#6495ED', iconCircle: PrimeIcons.CIRCLE},
  //     {status: 'Delivered',icon: PrimeIcons.CHECK, color: "#6495ED", iconCircle: PrimeIcons.CIRCLE}
  // ];

    this.load();
  }

  load() {
    this.shipmentService.getList().subscribe((response) => {
      this.shipment = response;
      // console.log(this.shipment)
    });
  }

  // checkTimeline(status: string, check: string) {

  // }

}
