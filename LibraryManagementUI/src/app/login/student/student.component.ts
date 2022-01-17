import { analyzeAndValidateNgModules } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { StudentService } from 'src/app/student.service';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  constructor(private service:StudentService,private toastr:ToastrService,private router: Router ) { }
@Input() log:any;
userName:string;
password:string;
id:number;

  ngOnInit(): void {
  }
  studentLog(){
    var val={
      userName:this.userName,
      password:this.password
    }
    this.service.login(val).subscribe(res=>{
      console.log(res);
      if(res[0].id==1 && this.userName !='Admin'){
     this.toastr.success(" Welcome "+this.userName,"LoggedIn Successfuuly");
     this.router.navigate(['/student-home']);
     localStorage.setItem("Auth", "True");
      }
      else{
        this.toastr.error("Wrong Credentials","login Failed");
      }
      this.StudentId();
    });
  }

  StudentId(){
    
    this.service.studentId(this.userName).subscribe(res=>{
     console.log(res);
     this.id=res;
     let data = { id: (this.id), userName: this.userName};
localStorage.setItem("Key", JSON.stringify(data));
    });
  }
}


