import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdminService } from 'src/app/admin.service';

@Component({
  selector: 'app-admin-orders',
  templateUrl: './admin-orders.component.html',
  styleUrls: ['./admin-orders.component.css'],
})
export class AdminOrdersComponent implements OnInit {
  data = JSON.parse(localStorage.getItem('AdminAuth'));
  adminAuth: any;
  pagedata: any;
  page = 1;
  itemsPerPage = 10;
  totalItems: any;

  constructor(private service: AdminService, private _r: Router) {}
  orderlist: any;
  ngOnInit(): void {
    this.adminAuth = this.data.auth;
    this.refreshOrderList();
    if (this.adminAuth === false) {
      this._r.navigateByUrl('login');
    }
  }

  refreshOrderList() {
    this.service.getOrders().subscribe((data: any) => {
      this.orderlist = data;
      console.log(data);
      this.pagedata = data;
      this.totalItems = data.length;
    });
  }
}
