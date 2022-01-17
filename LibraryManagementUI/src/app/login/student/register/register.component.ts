import { Component, Input,OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { StudentService } from 'src/app/student.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private service:StudentService,private toastr: ToastrService) { }
@Input() reg:any;
userName:string;
password:string;
usn:string;
  ngOnInit(): void {
  }
  studentReg(){
    var val={
      userName:this.userName,
      password:this.password,
      usn:this.usn
    }
    this.service.register(val).subscribe(res=>{
     console.log(res);
     if(res[0].id==1){
      this.toastr.success(this.userName ,"Registered Successfully");
     }
     else{
       this.toastr.error("username or usn Exists","Register Faied")
     }
    });
  }
}
