import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AdminService } from 'src/app/admin.service';

@Component({
  selector: 'app-admin-addbook',
  templateUrl: './admin-addbook.component.html',
  styleUrls: ['./admin-addbook.component.css']
})
export class AdminAddbookComponent implements OnInit {

  constructor(private service:AdminService,private toastr: ToastrService, private _r: Router) { 
    
    this.data = JSON.parse(localStorage.getItem('AdminAuth'));
    console.log(this.data);
    
  }

  @Input() book:any;
  bookId:string;
  bookTitle:string;
  authorName:string;
  cost:string;
  availableQuantity:string;
  data!: any;

  
  adminAuth:any;
  
  
  ngOnInit(): void {
    this.adminAuth=this.data.auth;
    if(this.adminAuth === false){
      this._r.navigateByUrl('login');
    }
  }


  addBook(){
    var val={
      bookId:this.bookId,
      bookTitle:this.bookTitle,
      authorName:this.authorName,
      cost: parseInt(this.cost),
      availableQuantity: parseInt(this.availableQuantity)
    }
    this.service.addBooks(val).subscribe(res=>{
      alert(res.toString());
      this.toastr.success("New Book","Added Successfully");
    });
  }
}
