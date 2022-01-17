import { identifierModuleUrl, isNgTemplate } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-home',
  templateUrl: './student-home.component.html',
  styleUrls: ['./student-home.component.css']
})
export class StudentHomeComponent implements OnInit {
  
  constructor() { }

  item:any;
  id:any;
  username:any;
  ngOnInit(): void {
     
    this.data();
  }
 
  data(){
    this.item = JSON.parse(localStorage.getItem("Key"));
    console.log(this.item);
    
    this.id=this.item.id;
    this.username=this.item.userName;
    console.log(this.id,this.username);
  }
}
