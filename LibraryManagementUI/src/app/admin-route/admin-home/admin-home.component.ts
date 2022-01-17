import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-home',
  templateUrl: './admin-home.component.html',
  styleUrls: ['./admin-home.component.css']
})
export class AdminHomeComponent implements OnInit {
  

  adminAuth:any;
  constructor(private _r:Router) { }

  ngOnInit(): void {
    if(this.adminAuth === false){
      this._r.navigateByUrl('login');
  }
}

}
