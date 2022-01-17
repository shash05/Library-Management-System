import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  constructor(private router:Router , private toastr:ToastrService) { }
@Input() admin:any;
userName:string;
password:string;
 
adminAuth={
auth:false
}
  ngOnInit(): void {
    localStorage.setItem("AdminAuth",  JSON.stringify(this.adminAuth));
  }
  adminLogin(){
    if(this.userName=="Admin" && this.password=="Admin@123"){
      this.toastr.success("admin Logged In");
      this.router.navigate(['/admin-home']);
      this.adminAuth={
        auth:true
        }
        localStorage.setItem("AdminAuth",  JSON.stringify(this.adminAuth));
    }
    else{
      this.toastr.error("Wrong Credentials");
    }
  }
}
