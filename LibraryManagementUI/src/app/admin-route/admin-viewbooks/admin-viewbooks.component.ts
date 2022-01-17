import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/admin.service';
@Component({
  selector: 'app-admin-viewbooks',
  templateUrl: './admin-viewbooks.component.html',
  styleUrls: ['./admin-viewbooks.component.css']
})
export class AdminViewbooksComponent implements OnInit {
  data = JSON.parse(localStorage.getItem('AdminAuth'));

  adminAuth:any;
  constructor(private service:AdminService) { }
  bookList:any;
  ngOnInit(): void {
    this.adminAuth=this.data.auth;
    this.refreshBookList();
  }

  refreshBookList(){
    this.service.viewBooks().subscribe((data: any) => {
      this.bookList=data 
      console.log(data);  
    });
  }
}
