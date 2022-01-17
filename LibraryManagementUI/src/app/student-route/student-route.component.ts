import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-route',
  templateUrl: './student-route.component.html',
  styleUrls: ['./student-route.component.css']
})
export class StudentRouteComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
logOut(){
  localStorage.clear();

}
}
