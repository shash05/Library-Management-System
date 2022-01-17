import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-route',
  templateUrl: './admin-route.component.html',
  styleUrls: ['./admin-route.component.css'],
})
export class AdminRouteComponent implements OnInit {
  data = JSON.parse(localStorage.getItem('AdminAuth'));

  adminAuth: any;
  constructor(private _r: Router) {}

  ngOnInit(): void {
    this.adminAuth = this.data.auth;
    if (this.adminAuth === false) {
      this._r.navigateByUrl('login');
    }
  }
}
